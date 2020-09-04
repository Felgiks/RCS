using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_moreSQL
{
    class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Connection()
        {
            Init();
        }
        private void Init()
        {
            server = "localhost";
            database = "ofiss";
            uid = "root";
            password = "addicted";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool Open()
        {
            connection.Open();
            return true;
        }
    }
}
