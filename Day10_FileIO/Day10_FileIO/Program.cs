using System;
using System.Collections.Generic;

namespace Day10_FILEIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Task1(); // genere skaitu listu un saglaba to .txt
            //  Task2(); // read skaitlu listu no .txt
            //  Task3(); // read skaitlus apriezta seciba no .txt
            //  Task4(); // read Tekstu no .txt
            Task5();
        }

        static void Task1()
        {
            List<int> a = new List<int>();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                a.Add(r.Next(11));
            }

            Tasks.WriteNumbers(a, "numbers.txt");
        }
        static void Task2()
        {
           List<int> b = Tasks.ReadNumbers("numbers.txt");

                foreach (int n in b)
                {
                    Console.Write(n + " ");
                }
            Console.WriteLine("");
        }
        static void Task3()
        {
            List<int> Iegutais = Tasks.ReadNumbers("numbers.txt");

            for (int i = Iegutais.Count - 1; i >= 0; i--)
            {
                Console.Write(Iegutais[i] + " ");
            }
        }
        static void Task4()
        {
            List<String> Iegutais = Tasks.ReadTekst("teksts.txt");

            foreach (String n in Iegutais)
            {
                Console.WriteLine(n + " ");
            }

        }
        static void Task5()
        {
            List<String> Saraksts = new List<String>() { "armanda", "gatis", "Juris" };

            Random r = new Random();

            Tasks.WriteText(Saraksts, "teksts.txt");
        }
        static void Task6()
        {
            String Izvele = "";
            while (Izvele != "0")
            {
                Console.WriteLine("1- Izvadit");
                Console.WriteLine("2- Pievienot");
                Console.WriteLine("3- Dzest");
                Console.WriteLine("0- Iziet");

                Izvele = Console.ReadLine();
                switch (Izvele)
                {
                    case "0":
                        {
                            return;
                        }
                    case "1":
                        {
                            List<String> Iegutais = Tasks.ReadTekst("teksts.txt");

                            foreach (String n in Iegutais)
                            {
                                Console.WriteLine(n + " ");
                            }

                            break;
                        }
                    case "2":
                        {

                            break;
                        }

                }
            }

        }
       
    }
}