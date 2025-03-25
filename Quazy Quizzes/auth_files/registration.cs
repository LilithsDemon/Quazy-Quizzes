using System;
using System.Globalization;
using Conn;
using QQStoredProcedures;
using Status;

namespace Registration
{
    class Register
    {
        private string _username;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private int _role;
        private bool _active;
        private int _securityQuestion;
        private string _securityAnswer;

        public Register(string username, string firstName, string lastName, string email, string password,
            int role, bool active, int securityQuestion, string securityAnswer)
        {
            this._username = username;
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
            this._password = password;
            this._role = role;
            this._active = active;
            this._securityQuestion = securityQuestion;
            this._securityAnswer = securityAnswer;
        }

        public CodeStatus RegisterUser()
        {
            // Check to see if user with that username already exists
            try
            {
                var reader = StoredProcedures.GetAllUserDataFromUsername(this._username);
                // If there is lines then a user with that username already exists
                if (reader.HasRows) return new CodeStatus(400, "Sorry a user with this username already exists");
            }
            catch (Exception ex) // If exception states that no data exists then we know that the username is free
            {

            }


            // Insert user to database
            string insertSQL = "INSERT INTO `Users`(`UserID`, `UserName`, `FirstName`, `LastName`, `Email`, `Password`, `Role`, `Active`, `SecurityQ`, `SecurityA`, `LastLogIn`)" +
                            " VALUES (null, @userName, @firstName, @lastName, @email, @password, @role, @active, @securityQ, @securityA, @lastLogIn)";
            string[] insertParamNames = { "@userName", "@firstName", "@lastName", "@email", "@password", "@role", "@active", "@securityQ", "@securityA", "@lastLogIn" };

            this._password = BCrypt.Net.BCrypt.HashPassword(this._password);
            this._securityAnswer = BCrypt.Net.BCrypt.HashPassword(this._securityAnswer);

            DateTime dateTime = DateTime.Now;

            string[] insertParameters = { this._username, this._firstName, this._lastName, this._email, this._password,
                this._role.ToString(), this._role.ToString(), this._securityQuestion.ToString(), this._securityAnswer, dateTime.ToString("yyyy-MM-dd HH:mm:ss")};

            bool inserted = false;

            try
            {
                inserted = new ConnectionHandler().ExectuteCommand(insertSQL, insertParamNames, insertParameters);
            }
            catch (Exception ex)
            {
                return new CodeStatus(400, ex.Message);
            }

            // Tell user their account was created
            return inserted ? new CodeStatus(200, "User created") : new CodeStatus(400, "Was not able to add user to database");
        }
    }
}