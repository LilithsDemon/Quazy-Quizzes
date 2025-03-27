using System;
using Conn;
using MySqlConnector;
using Quazy_Quizzes;
using Status;
using UserData;
using QQStoredProcedures;

namespace LogIn
{
    class UserLogin
    {
        private string _username;
        private string _password;
        private int _securityQuestion;
        private string _securityAnswer;

        public UserLogin(string username, string password)
        {
            this._username = username;
            this._password = password;
        }

        public UserLogin(string username, string password, int securityQuestion, string securityAnswer)
        {
            this._username = username;
            this._password = password;
            this._securityQuestion = securityQuestion;
            this._securityAnswer = securityAnswer;
        }

        // Get's users data based on the username
        private MySqlDataReader GetUserReader()
        {
            return StoredProcedures.GetAllUserDataFromUsername(this._username);
        }

        private void UpdateLastLogIn()
        {
            // Update the last login time
            string updateSQL = "UPDATE `Users` SET `LastLogIn` = @lastLogIn WHERE `UserName` = @userName";
            string[] updateParamNames = { "@lastLogIn", "@userName" };
            string[] updateParameters = { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), this._username };
            new ConnectionHandler().ExectuteCommand(updateSQL, updateParamNames, updateParameters);
        }

        private void SetUserData(int userID, string username, string firstName, string lastName, int role, string email)
        {
            // Set the user data to the saved user class
            Program._user.SetData(userID, username, firstName, lastName, role, email);
        }

        private CodeStatus AuthenticateUser(MySqlDataReader reader)
        {
            //Checks if the password and security answer are correct
            bool authenticate = BCrypt.Net.BCrypt.Verify(this._password, reader["Password"].ToString());
            if (authenticate) // If Correct Login
            {
                // Set the program user data
                SetUserData(Convert.ToInt32(reader["UserID"]), reader["UserName"].ToString(), reader["FirstName"].ToString(),
                    reader["LastName"].ToString(), Convert.ToInt32(reader["Role"]), reader["Email"].ToString());

                // Logged in
                UpdateLastLogIn();
                return new CodeStatus(200, "Login Successful");
            }
            else return new CodeStatus(401, "User entered the wrong password, or security question");
        }

        private CodeStatus AuthenticateUserWSecurity(MySqlDataReader reader)
        {
            //Checks if the password and security answer are correct
            bool authenticate = BCrypt.Net.BCrypt.Verify(this._password, reader["Password"].ToString()) && _securityQuestion == Convert.ToInt32(reader["SecurityA"]) && BCrypt.Net.BCrypt.Verify(this._securityAnswer, reader["SecurityA"].ToString());
            if (authenticate) // If Correct Login
            {
                // Set the program user data
                SetUserData(Convert.ToInt32(reader["UserID"]), reader["UserName"].ToString(), reader["FirstName"].ToString(),
                    reader["LastName"].ToString(), Convert.ToInt32(reader["Role"]), reader["Email"].ToString());

                // Logged in
                UpdateLastLogIn();
                return new CodeStatus(200, "Login Successful");
            }
            else return new CodeStatus(401, "User entered the wrong password, or security question");
        }

        // Login using only username and password not security Question
        public CodeStatus LoginWOSecurity()
        {
            try // If no error then the user does exist
            {
                var reader = GetUserReader();
                if (reader.Read())
                {
                    // Check if user's account is locked
                    if (reader["Active"].ToString() == "False") return new CodeStatus(403, "User account is locked");

                    return AuthenticateUser(reader);
                }
            }
            catch (Exception ex) // If error then the user does not exist
            {
                if (ex.Message == "No rows") return new CodeStatus(404, "User entered the wrong credentials");
            }

            return new CodeStatus(400, "Unknown error");
        }

        // Login using security question
        public CodeStatus LoginWSecurity()
        {
            try // If no error then the user does exist
            {
                var reader = GetUserReader();
                if (reader.Read())
                {
                    // Check if user's account is locked
                    if (reader["Active"].ToString() == "False") return new CodeStatus(403, "User account is locked");

                    return AuthenticateUserWSecurity(reader);
                }
            }
            catch (Exception ex) // If error then the user does not exist
            {
                if (ex.Message == "No rows") return new CodeStatus(404, "User entered the wrong credentials");
            }

            return new CodeStatus(400, "Unknown error");
        }
    }
}