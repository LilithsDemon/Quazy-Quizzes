using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using MySqlConnector;
using Status;


namespace Conn
{
    class ConnectionHandler
    {
        //Hard coded values for the database values
        private string _host = "plesk.remote.ac";
        private string _dbName = "ws328700_CSD";
        private string _username = "ws328700_WSDUser";
        private string _password = "@ms9I72g3";
        private string _constring = "";

        // This sets up the class making the connection string to the database
        public ConnectionHandler()
        {
            this._constring = $"Server={this._host};User={this._username};Database={this._dbName};Password={this._password}; CharSet=utf8; SslMode=none";
        }

        // Check Connection
        public CodeStatus CheckConnection()
        {
            MySqlConnection con = new MySqlConnection(this._constring);
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                if (e.GetType() == typeof(MySqlConnector.MySqlException)) return new CodeStatus(503, "Error with connection to Database");
                else return new CodeStatus(500, "Unknown error");
            }
            return new CodeStatus(200, "Connection Established");
        }

        // Open connection for inside this class, is private so should not be able to be used outside the class
        private MySqlConnection OpenConnection()
        {
            MySqlConnection con = new MySqlConnection(this._constring);
            con.Open();
            return con;
        }

        //Closes the connection opened to the database inside of this class
        private void CloseConnection()
        {
            MySqlConnection con = new MySqlConnection(this._constring);
            con.Close();
        }

        // A public way of getting a connection if you want to do your own things with the database connection
        public MySqlConnection GetConnection() => new MySqlConnection(this._constring);


        // For use in the class, just checks that there are the same number of parameters given in both parameters
        private bool CheckParams(string[] paramNames, string[] parameters)
        {
            if (paramNames.Length == parameters.Length) return true;
            else return false;
        }

        // Creates a parametised statement to be sent to the database
        private MySqlCommand CreateCommand(MySqlConnection con, string sql, string[] paramNames, string[] parameters)
        {
            var command = con.CreateCommand();
            command.CommandText = @sql;
            // Goes through paramNames and ties the paremeter to the name for the parametised query
            for (int i = 0; i < paramNames.Length; i++)
            {
                command.Parameters.AddWithValue(paramNames[i], parameters[i]);
            }
            return command;
        }

        // Creates a the command sent to the database for a stored procedure.
        private MySqlCommand CreateStoredCommand(MySqlConnection con, string storedName, string[] paramNames, string[] parameters)
        {
            var command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedName;
            // Goes through paramNames and ties the paremeter to the name for the parametised query
            for (int i = 0; i < paramNames.Length; i++)
            {
                command.Parameters.AddWithValue(paramNames[i], parameters[i]);
            }
            return command;
        }

        // Executes query with params such as Select * From `Users` Where ...
        public MySqlDataReader ExectuteQuery(string sql, string[] paramName, string[] parameters)
        {
            if (!CheckParams(paramName, parameters)) throw new ArgumentException("paramName and parameters must have the same length");

            MySqlConnection con = OpenConnection();

            var command = CreateCommand(con, sql, paramName, parameters);
            var reader = command.ExecuteReader();
            CloseConnection();
            if (reader.HasRows) return reader;
            else throw new Exception("No rows returned");
        }

        // Executes a query when there are no params such as Select * From `Users`
        public MySqlDataReader ExecuteQueryNoParams(string sql)
        {
            MySqlConnection con = OpenConnection();
            var command = con.CreateCommand();
            command.CommandText = @sql;
            var reader = command.ExecuteReader();
            CloseConnection();
            if (reader.HasRows) return reader;
            else throw new Exception("No rows returned");
        }

        //Executes a command such as Insert ... with parameters
        public bool ExectuteCommand(string sql, string[] paramName, string[] parameters)
        {
            if (!CheckParams(paramName, parameters)) throw new ArgumentException("Param Names and parameters must have the same length");

            MySqlConnection con = OpenConnection();
            var command = CreateCommand(con, sql, paramName, parameters);
            int rows = command.ExecuteNonQuery();
            CloseConnection();
            // If no rows were affected return false to show it did not work else return true
            if (rows == -1) return false;
            else return true;
        }

        // Executes a command with no parameters
        public bool ExecuteCommandNoParams(string sql)
        {
            MySqlConnection con = OpenConnection();
            var command = con.CreateCommand();
            command.CommandText = @sql;
            int rows = command.ExecuteNonQuery();
            CloseConnection();
            // If no rows were affected return false to show it did not work else return true
            if (rows == -1) return false;
            else return true;
        }

        // This will be used to be able to use a stored query that is used for getting data from the database
        public MySqlDataReader StoredQuery(string procedureName, string[] paramNames, string[] parameters)
        {
            MySqlConnection con = OpenConnection();
            var command = CreateStoredCommand(con, procedureName, paramNames, parameters);
            var reader = command.ExecuteReader();
            CloseConnection();
            return reader;
        }

        public List<string> GetCourses()
        {
            string query = "SELECT CourseName FROM Courses";
            List<string> courses = new List<string>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(reader["CourseName"].ToString());
                        }
                    }
                }
            }

            return courses;
        }

        public List<string> GetExams()
        {
            string query = "SELECT ExamName FROM Exams";
            List<string> exams = new List<string>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            exams.Add(reader["ExamName"].ToString());
                        }
                    }
                }
            }

            return exams;
        }
    }
}