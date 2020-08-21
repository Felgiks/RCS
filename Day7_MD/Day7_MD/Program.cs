using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Globalization;

namespace Day7_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise = "";
            Console.WriteLine("Jusu iepirkumu grozs:");        
            List<String> Grozs = new List<String>();
            Grozs.Add("Abols");
            Grozs.Add("Maize");
            Grozs.Add("Makaroni");

            while (choise != "0")
            {
                Console.WriteLine("Ko jus velaties darit ar grozu?");
                Console.WriteLine("1 - Pievienot preci");
                Console.WriteLine("2 - Iznemt preci");
                Console.WriteLine("3 - Notirit sarakstu");
                Console.WriteLine("4 - Apskatit sarakstu");
                Console.WriteLine("0 - EXIT");

                choise = Console.ReadLine();
                    switch (choise)
                    {
                        case "0":
                        {
                            return;
                        }
                        case "1":
                        {
                            Console.WriteLine("Ievadiet preces nosaukumu");
                            Grozs.Add(Console.ReadLine());
                            break;
                        }
                        case "2":
                        {
                            Console.WriteLine("Kuru preci no saraksta velaties iznemt?");
                            Grozs.Remove(Console.ReadLine());
                            break;
                        }
                        case "3":
                        {
                            Console.WriteLine("Saraksts notirits!");
                            Grozs.Clear();
                            break;
                        }
                        case "4":
                        {
                            Console.WriteLine("Jusus Saraksts!");
                            foreach (var name in Grozs)
                            {
                                Console.WriteLine(name);
                            }
                            break;
                        }
                        default:
                            {
                                Console.WriteLine("Nepareiza ievade");
                                break;
                            }
                    }
            }
        }
    }
}
