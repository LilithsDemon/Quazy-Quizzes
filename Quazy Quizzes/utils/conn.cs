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
        private string _host = "plesk.remote.ac";
        private string _dbName = "ws328700_CSD";
        private string _username = "ws328700_WSDUser";
        private string _password = "@ms9I72g3";
        private string _constring = "";

        public ConnectionHandler()
        {
            this._constring = $"Server={this._host};User={this._username};Database={this._dbName};Password={this._password}; CharSet=utf8; SslMode=none";
        }

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

        private MySqlConnection OpenConnection()
        {
            MySqlConnection con = new MySqlConnection(this._constring);
            con.Open();
            return con;
        }

        private void CloseConnection()
        {
            MySqlConnection con = new MySqlConnection(this._constring);
            con.Close();
        }

        public MySqlConnection GetConnection() => new MySqlConnection(this._constring);

        private bool CheckParams(string[] paramNames, string[] parameters)
        {
            return paramNames.Length == parameters.Length;
        }

        private MySqlCommand CreateCommand(MySqlConnection con, string sql, string[] paramNames, string[] parameters)
        {
            var command = con.CreateCommand();
            command.CommandText = @sql;
            for (int i = 0; i < paramNames.Length; i++)
            {
                command.Parameters.AddWithValue(paramNames[i], parameters[i]);
            }
            return command;
        }

        private MySqlCommand CreateStoredCommand(MySqlConnection con, string storedName, string[] paramNames, string[] parameters)
        {
            var command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedName;
            for (int i = 0; i < paramNames.Length; i++)
            {
                command.Parameters.AddWithValue(paramNames[i], parameters[i]);
            }
            return command;
        }

        public MySqlDataReader ExectuteQuery(string sql, string[] paramName, string[] parameters)
        {
            if (!CheckParams(paramName, parameters)) throw new ArgumentException("paramName and parameters must have the same length");

            MySqlConnection con = OpenConnection();
            var command = CreateCommand(con, sql, paramName, parameters);
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public MySqlDataReader ExecuteQueryNoParams(string sql)
        {
            MySqlConnection con = OpenConnection();
            var command = con.CreateCommand();
            command.CommandText = @sql;
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public bool ExectuteCommand(string sql, string[] paramName, string[] parameters)
        {
            if (!CheckParams(paramName, parameters)) throw new ArgumentException("Param Names and parameters must have the same length");

            MySqlConnection con = OpenConnection();
            var command = CreateCommand(con, sql, paramName, parameters);
            int rows = command.ExecuteNonQuery();
            CloseConnection();
            return rows != -1;
        }

        public bool ExecuteCommandNoParams(string sql)
        {
            MySqlConnection con = OpenConnection();
            var command = con.CreateCommand();
            command.CommandText = @sql;
            int rows = command.ExecuteNonQuery();
            CloseConnection();
            return rows != -1;
        }

        public MySqlDataReader StoredQuery(string procedureName, string[] paramNames, string[] parameters)
        {
            MySqlConnection con = OpenConnection();
            var command = CreateStoredCommand(con, procedureName, paramNames, parameters);
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
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
