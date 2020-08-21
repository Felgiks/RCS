using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_HomeWork
{
    class Extra1
    {
        public static void Run()
        {
            String filename = "C:\\Users\\Arturs Feldmanis\\Desktop\\Test.txt";

            String choice = "";

            List<String> lstOfStrings = FileOperations.ReadStringLst(filename);
            while (choice != "0")
            {
                Console.WriteLine();
                Console.WriteLine("1- Izvadit");
                Console.WriteLine("2- Pievienot");
                Console.WriteLine("3- Dzest");
                Console.WriteLine("4- Iztirit sarakstu");
                Console.WriteLine("0- Iziet");

                Console.WriteLine("Ko velaties darit?");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Print(lstOfStrings);
                        break;
                    case "2":
                        Add(lstOfStrings, filename);
                        break;
                    case "3":
                        Remove(lstOfStrings, filename);
                        break;
                    case "4":
                        lstOfStrings.Clear();
                        FileOperations.WriteStringLst(lstOfStrings, filename);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;

                }
            }
        }

        static void Print(List<String> lst)
        {
            Console.WriteLine();

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss");
                return;
            }

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(i + "- " + lst[i]);
            }
        }

        static void Add(List<String> lst, String filename)
        {
            Console.WriteLine("Pievienojiet elementu!");
            lst.Add(Console.ReadLine());

            FileOperations.WriteStringLst(lst, filename);
        }

        static void Remove(List<String> lst, String filename)
        {
            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss");
                return;
            }

            Print(lst);
            Console.WriteLine("Kuru elementu velaties dzest?");

            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                lst.RemoveAt(i);
                FileOperations.WriteStringLst(lst, filename);
            }
            catch
            {
                Console.WriteLine("Nekorekta ievade!");
            }

        }
    }
}
