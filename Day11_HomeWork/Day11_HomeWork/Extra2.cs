using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Day11_HomeWork;

namespace Day11_Homework
{
    class Extra2
    {
        public static void Run()
        {
            String choice = "";
            List<String> fileData = new List<String>();
            while (choice != "0")
            {

                Console.WriteLine("1- atvert");
                Console.WriteLine("2- jauns fails");
                Console.WriteLine("0- iziet");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ReadFile(fileData);
                        break;
                    case "2":
                        NewFile(fileData);
                        break;
                    case "0":
                        return; ;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }

            }

        }

        private static void NewFile(List<String> fileData)
        {
            Console.WriteLine("Ievadiet faila nosaukumu ar celu!");

            String filename = Console.ReadLine();
            if (!filename.Contains("\\"))
            {
                filename = "C:\\Users\\Marti\\Desktop\\" + filename;
            }

            EditList(fileData);
            SaveFile(fileData, filename);
        }

        private static void ReadFile(List<String> fileData)
        {

            Console.WriteLine("Kadu failu velaties apstradat?");
            String filename = Console.ReadLine();

            if (!filename.Contains("\\"))
            {
                filename = "C:\\Users\\Marti\\Desktop\\" + filename;
            }
            
            fileData = FileOperations.ReadStringLst(filename);
            EditList(fileData);
            Console.WriteLine("Vai velaties saglabat esoso vai saglabat jaunu failu?- old/new");
            String choice = Console.ReadLine();
            if (choice != "old")
            {
                Console.WriteLine("Ierakstiet faila nosaukumu");
                filename = Console.ReadLine();

                if (!filename.Contains("\\"))
                {
                    filename = "C:\\Users\\Marti\\Desktop\\" + filename;
                }


            }

            SaveFile(fileData, filename);


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

        static void EditList(List<String> lst)
        {
            String choice = "";

            while (choice != "exit")
            {

                Print(lst);

                Console.WriteLine("Ievadiet rindinas numuru, lai redigetu, vienkarsi rakstiet, lai pievienotu" +
                    "jaunu rindinu, un exit, lai izietu");
                choice = Console.ReadLine();

                int numChoice;

                if (choice == "exit")
                {
                    return;
                }
                else if (int.TryParse(choice, out numChoice) && lst.Count != 0)
                {
                    Console.WriteLine("Kadu gribat rindinu?");
                    lst[numChoice] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ko velaties pievienot?");
                    lst.Add(Console.ReadLine());
                }
            }
        }


        static void SaveFile(List<String> fileData, String filename)
        {
            FileOperations.WriteStringLst(fileData, filename);
        }
    }
}