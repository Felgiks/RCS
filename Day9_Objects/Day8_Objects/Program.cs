using System;
using System.Collections.Generic;

namespace Day8_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }
        static void Task3()
        {
            string choise = "";
            Console.WriteLine("Jusu Auto");
            List<String> Car = new List<String>();
            Car c1 = new Car("Red", "Ford", "Mustang");
            Car c2 = new Car("Blue", "Audi", "RS6");
            Car c3 = new Car("White", "Honda", "Civic");

            Car.Add("asd");




            while (choise != "0")
            {
                Console.WriteLine("Ko jus velaties darit ar sarakstu?");
                Console.WriteLine("1 - Pievienot Auto");
                Console.WriteLine("2 - Iznemt Auto");
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
                            Console.WriteLine("Ievadiet auto nosaukumu");
                            Car.Add(Console.ReadLine());
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Kuru preci no saraksta velaties iznemt?");
                            Car.Remove(Console.ReadLine());
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Saraksts notirits!");
                            Car.Clear();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Jusus Saraksts!");

                            for (int i = 0; i < Car.Count; i++)
                                List<Studenti> StudentInfo = new List<Studenti>();
                            {
                               Car[i].PrintInfo();
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
        static void Task2()
        {
            Example Studenti = new Example();
            Studenti a1 = new Studenti("Janis", "Maksts", 2);
            Studenti a2 = new Studenti("Karlis", "Apsis", 1);
            Studenti a3 = new Studenti("Ilze", "Jana", 3);

            List<Studenti> StudentInfo = new List<Studenti>();
            StudentInfo.Add(a1);
            StudentInfo.Add(a2);
            StudentInfo.Add(a3);
            StudentInfo.Add(new Studenti("Alla", "Priede", 4));
            a1.Name = "Aigars";
            
            for (int i = 0; i< StudentInfo.Count; i++)
            {
                StudentInfo[i].PrintInfoStudent();
            }
        }
        static void Task1()
        {/*
            Example objName = new Example(); //otra dala, inicializee konstruktoru
            objName.a = 3;
            objName.b = 5;

            Console.WriteLine("obj1- ");
            objName.Sum();

            Example objName2 = new Example(); //cits objekts neizmaina iepriekseja objekta vertibu.
            objName2.a = 55;
            objName2.b = 99;
            Console.WriteLine("obj2- ");
            objName2.Sum();
            objName.Sum();

            Car c1 = new Car("GReen", "ford", "mustang");
            c1.PrintInfo();
         */
            
        }
    }
}
