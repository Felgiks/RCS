using System;

namespace Day19_moreSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            Task2();
            
        }

        private static void Task2()
        {
            Savienojums Sav = new Savienojums();
            // Sav.Open();
            // Sav.Ievietosana();
            Sav.Selekteesana();
            
        }

        static void Task1()
        {
            Connection con = new Connection();
            // Console.WriteLine(con.Open());
           // con.Insert();
            con.Select();
        }
    }
}
