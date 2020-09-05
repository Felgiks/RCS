using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Day19_moreSQL
{
    class Savienojums
    {
        private MySqlConnection savienojums;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Savienojums()
        {
            Init();
        }
        private void Init()
        {
            server = "localhost";
            database = "majdzivniekuvaikals";
            uid = "root";
            password = "addicted";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            savienojums = new MySqlConnection(connectionString);
        }
        public void Selekteesana()
        {
            List<Animals> AnimalList = new List<Animals>();

            String query = "SELECT animalName, animaltype.typeName FROM animal, animaltype";

            if (this.Open() == true)
            {
                Console.WriteLine("Savienojas...");
                MySqlCommand cmd = new MySqlCommand(query, savienojums);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AnimalList.Add(new Animals(reader["animalName"].ToString(), reader["typeName"].ToString()));
                }
                reader.Close();

                this.Close();

                foreach (Animals animal in AnimalList)
                {
                    Console.WriteLine(animal.animalName  + " " + animal.animalType);
                }
            }
            else
            {
                Console.WriteLine("Savienojums neizdevas no Select");
            }
        }
        public void Ievietosana()
        {
            String query = "INSERT INTO animal (animalName, typeID) VALUES ('Flufijs', 2)";
            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, savienojums);
                cmd.ExecuteNonQuery();

                this.Ievietosana();
            }
            else
            {
                Console.WriteLine("Neizdevas savienoties ievietosanai");
            }
        }
        public bool Open()
        {
            try
            {
                Console.WriteLine("Tring to connect...");
                savienojums.Open();
            }
            catch
            {
                Console.WriteLine("No connect from Open bool");
                return false;
            }
            return true;
        }
        public bool Close()
        {
            try
            {
                savienojums.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
