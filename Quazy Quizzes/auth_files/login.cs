using System;
using Conn;
using Status;

namespace LogIn
{
    class UserLogin
    {
        private string _username;
        private string _password;
        private int _securityQuestion;
        private string _securityAnswer;

        public UserLogin(string username, string password, int securityQuestion, string securityAnswer)
        {
            this._username = username;
            this._password = password;
            this._securityQuestion = securityQuestion;
            this._securityAnswer = securityAnswer;
        }

        public CodeStatus Login()
        {
            try // If no error then the user does exist
            {
                var reader = new ConnectionHandler().ExectuteQuery("SELECT * FROM `Users` WHERE `Username` = @username",
                    new string[] { "@username" }, new string[] { this._username });
                if (reader.Read())
                {
                    bool authenticate = BCrypt.Net.BCrypt.Verify(this._password, reader["Password"].ToString()) && BCrypt.Net.BCrypt.Verify(this._securityAnswer, reader["SecurityA"].ToString());
                    return authenticate ? new CodeStatus(200, "User has successfully logged in") : new CodeStatus(400, "User entered the wrong credentials");
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