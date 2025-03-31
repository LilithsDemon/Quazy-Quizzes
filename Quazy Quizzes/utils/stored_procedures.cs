using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Status;
using Conn;
using System.Data;
using System.Security.Cryptography;

namespace QQStoredProcedures
{
    static class StoredProcedures
    {
        public static MySqlDataReader GetUsersCourses(int userId)
        {
            string procedureName = "GetUsersCourses";
            string[] paramNames = new string[] {"@UserID"};
            string[] parameters = new string[] { userId.ToString() };
            return new ConnectionHandler().StoredQuery(procedureName, paramNames, parameters);
        }

        public static MySqlDataReader GetUsersInCourse(int courseId)
        {
            string procedureName = "GetUsersInCourse";
            string[] paramNames = new string[] { "@CourseID" };
            string[] parameters = new string[] { courseId.ToString() };
            return new ConnectionHandler().StoredQuery(procedureName, paramNames, parameters);
        }

        public static MySqlDataReader GetAllCourseExamsWithScores(int userId, int courseId)
        {
            string procedureName = "GetAllCourseExamsWithScores";
            string[] paramNames = new string[] { "@UserID", "@CourseID" };
            string[] parameters = new string[] { userId.ToString(), courseId.ToString() };
            return new ConnectionHandler().StoredQuery(procedureName, paramNames, parameters);
        }

        public static MySqlDataReader GetAllStudents(string search)
        {
            string procedureName = "GetAllStudents";
            string[] paramNames = new string[] { "@Search" };
            string[] parameters = new string[] { search };
            return new ConnectionHandler().StoredQuery(procedureName, paramNames, parameters);
        }

        public static MySqlDataReader GetAllLecturers(string search)
        {
            string procedureName = "GetAllLecturers";
            string[] paramNames = new string[] { "@Search" };
            string[] parameters = new string[] { search };
            return new ConnectionHandler().StoredQuery(procedureName, paramNames, parameters);
        }

        public static MySqlDataReader GetAllUserDataFromUsername(string username)
        {
            string procedureName = "GetUserData";
            string[] paramNames = new string[] { "@Username" };
            string[] parameters = new string[] { username };
            return new ConnectionHandler().StoredQuery(procedureName, paramNames, parameters);
        }
        public static MySqlDataReader GetUsersExamsWithScores(int userId)
        {
            string procedureName = "GetUsersExamsWithScores";
            string[] paramNames = new string[] { "@UserID" };
            string[] parameters = new string[] { userId.ToString() };
            return new ConnectionHandler().StoredQuery(procedureName, paramNames, parameters);
        }

    }
}