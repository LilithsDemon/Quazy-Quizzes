using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using MySqlConnector;


namespace Conn
{
    class ConnectionHandler
    {
        // This is not how this should be done but I am doing it anyway
        private string _host = "plesk.remote.ac";
        private string _dbName = "ws328700_CSD";
        private string _username = "ws328700_WSDUser";
        private string _password = "@ms9I72g3";
        private string _constring = "";

        public ConnectionHandler()
        {
            this._constring = $"Server={this._host};User={this._username};Database={this._dbName};Password={this._password}; CharSet=utf8; SslMode=none";
        }

        private MySqlConnection OpenConnection()
        {
            MySqlConnection con = new MySqlConnection(this._constring);
            con.Open();
            return con;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(this._constring);
        }

        private void CloseConnection()
        {
            MySqlConnection con = new MySqlConnection(this._constring);
            con.Close();
        }

        private MySqlCommand createCommand(MySqlConnection con, string sql, string[] paramNames, string[] parameters)
        {
            var command = con.CreateCommand();
            command.CommandText = @sql;
            for (int i = 0; i < paramNames.Length; i++)
            {
                command.Parameters.AddWithValue(paramNames[i], parameters[i]);
            }
            return command;
        }


        public MySqlDataReader exectuteQuery(string sql, string[] paramName, string[] parameters)
        {
            if (paramName.Length != parameters.Length)
            {
                throw new ArgumentException("paramName and parameters must have the same length");
            }

            MySqlConnection con = OpenConnection();

            var command = createCommand(con, sql, paramName, parameters);
            var reader = command.ExecuteReader();
            CloseConnection();
            if (reader.HasRows)
            {
                return reader;
            }
            else
            {
                throw new Exception("No rows returned");
            }
        }

        public MySqlDataReader executeQueryNoParams(string sql)
        {
            MySqlConnection con = OpenConnection();
            var command = con.CreateCommand();
            command.CommandText = @sql;
            var reader = command.ExecuteReader();
            CloseConnection();
            if (reader.HasRows)
            {
                return reader;
            }
            else
            {
                throw new Exception("No rows returned");
            }
        }

        public void exectuteCommand(string sql, string[] paramName, string[] parameters)
        {
            MySqlConnection con = OpenConnection();
            var command = createCommand(con, sql, paramName, parameters);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void executeCommandNoParams(string sql)
        {
            MySqlConnection con = OpenConnection();
            var command = con.CreateCommand();
            command.CommandText = @sql;
            command.ExecuteNonQuery();
            CloseConnection();
        }

    }
}