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
using Quazy_Quizzes.user;

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
    }
}