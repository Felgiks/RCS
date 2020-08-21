using System;
using System.Collections.Generic;
using System.Text;

namespace MacosProgrammet1
{
    class Uzdevums
    {
        public static void Pirmais()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Otrais()
        {
            String Izveele = "";
            double a = 3.14;
            double b = 8.67;

            while (Izveele != "exit")
            {
                Console.WriteLine(a * b);
            }
        }
        public static void Masiivs()
        {

            int[] Nosaukums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            foreach (int Index in Nosaukums)
            {
                Console.WriteLine(Index);
            }

            Console.WriteLine("Beidzas foreach");

            for (int i = 0; i < Nosaukums.Length; i++)
            {
                Console.Write("Indeks = " + i);
                Console.WriteLine(" te ieksaa ir = " + Nosaukums[i]);
            }
        }
        public static void WhileUzd()
        {

            String choise = "";
            int summa = 0;

            while (choise != "Y")
            {

                int a = summa;
                Console.WriteLine(a + "aplis");
                Console.ReadLine();
            }

        }
        public static void Tests1()
        {

            List<Lietotajs> listOfUsers = new List<Lietotajs>()
            {
             new Lietotajs() { Name = "John Doe", Age = 42 },
             new Lietotajs() { Name = "Jane Doe", Age = 34 },
             new Lietotajs() { Name = "Joe Doe", Age = 8 },
            };

            for (int i = 0; i < listOfUsers.Count; i++)
            {
                Console.WriteLine(listOfUsers[i].Name + " is " + listOfUsers[i].Age + " years old");
            }
            Console.ReadKey();
        }
    }
    
}
