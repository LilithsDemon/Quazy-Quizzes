using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserData
{
    class User
    {
        public int _userID;
        public  string _username;
        public  string _firstName;
        public  string _lastName;
        public  int _role;
        public  string _email;

        public User()
        {
            ClearData();
        }

        public User(int userID, string username, string firstName, string lastName, int role, string email)
        {
            SetData(userID, username, firstName, lastName, role, email);
        }

        public void ClearData()
        {
            _userID = 0;
            _username = "";
            _firstName = "";
            _lastName = "";
            _role = 0;
            _email = "";
        }

        public void SetData(int userID, string username, string firstName, string lastName, int role, string email)
        {
            _userID = userID;
            _username = username;
            _firstName = firstName;
            _lastName = lastName;
            _role = role;
            _email = email;
        }
    }
}
