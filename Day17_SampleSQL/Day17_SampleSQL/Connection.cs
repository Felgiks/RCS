using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Day17_SampleSQL
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

        public void Select()
        {
            List<Jobs> jobLst = new List<Jobs>();

            String query = "SELECT jobName, jobDescription FROM jobs";

            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    jobLst.Add(new Jobs(reader["jobName"].ToString(), reader["jobDescription"].ToString()));

                }

                reader.Close();

                this.Close();

                foreach (Jobs job in jobLst)
                {
                    Console.WriteLine(job.jobName + "," + job.jobDescr);
                }
            }
            else
            {
                Console.WriteLine("Nesanak savienoties!");
            }
        }

        public void Insert()
        {
            String query = "INSERT INTO jobs (jobName, jobDescription)" +
                " VALUES('Elektronikis', 'Elektribas burvis')";
            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                this.Close();
            }
            else
            {
                Console.WriteLine("Nesanak savienoties!");
            }
        }

        public bool Open()
        {
            try
            {
                connection.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool Close()
        {
            try
            {
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }

}