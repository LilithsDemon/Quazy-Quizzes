using System;
using Conn;
using Status;

namespace Registration
{
    class Register
    {
        private string _username = null;
        private string _firstName = null;
        private string _lastName = null;
        private string _password = null;
        private bool? _role = null;
        private int? _securityQuestion = null;
        private string _securityAnswer = null;

        public Register(string username, string firstName, string lastName, string password, bool role, int securityQuestion, string securityAnswer)
        {
            this._username = username;
            this._firstName = firstName;
            this._lastName = lastName;
            this._password = password;
            this._role = role;
            this._securityQuestion = securityQuestion;
            this._securityAnswer = securityAnswer;
        }

        public CodeStatus RegisterUser()
        {
            // Check to see if user with that username already exists
            try
            {
                var reader = new ConnectionHandler().ExectuteQuery("SELECT * FROM `Users` WHERE 'UserName' = @username",
                new string[] { "@username" }, new string[] { this._username });
                // If there is lines then the user exists and should error
                return new CodeStatus(400, "Sorry a user with this username already exists");

            }
            catch (Exception ex) // If exception states that no data exists then we know that the username is free
            {
                if (ex.Message != "No rows") return new CodeStatus(400, ex.Message);
            }


            // Insert user to database
            string insertSQL = "INSERT INTO `Users`(`UserID`, `UserName`, `FirstName`, `LastName`, `Password`, `Role`, `Active`, `SecurityQ`, `SecurityA`)" +
                            " VALUES (null, @userName, @firstName, @lastName, @password, @role, @active, @securityQ, @securityA)";
            string[] insertParamNames = { "@userName", "@firstName", "@lastName", "@password", "@role", "@active", "securityQ", "securityA" };

            this._password = BCrypt.Net.BCrypt.HashPassword(this._password);
            this._securityAnswer = BCrypt.Net.BCrypt.HashPassword(this._securityAnswer);

            string[] insertParameters = { this._username, this._firstName, this._lastName, this._password, this._role.ToString(), this._role.ToString(), this._securityQuestion.ToString(), this._securityAnswer };

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