using System;
using System.ComponentModel;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();
            Sveiciens();
            while (true)
            {
                Random Randoms = new Random();
                int PareizaisNumurs = Randoms.Next(1, 10);
                int MinejumuReizes = 1;
                int Minejums = 0;
                Console.WriteLine("Uzmini numuru no 1 lidz 10!");

                while (Minejums != PareizaisNumurs)
                {

                    string ievade = Console.ReadLine();
                    if (!int.TryParse(ievade, out Minejums))
                    {
                        KrasainaAtbilde(ConsoleColor.Red, "Ludzu, ievadi skaitli, nevis ko citu!");
                        MinejumuReizes += 1;
                        continue;
                    }
                    Minejums = Int32.Parse(ievade);

                    if (Minejums != PareizaisNumurs)
                    {
                        KrasainaAtbilde(ConsoleColor.Red, "Skaitlis nepareizs, megini velreiz!");
                        MinejumuReizes += 1;
                    }
                }
                KrasainaAtbilde(ConsoleColor.Green, "Tu uzmineji manu skaitli ar " + MinejumuReizes + " reizi!");
                Console.WriteLine("Minesi velreiz? [Y or N]");
                string atbilde = Console.ReadLine().ToUpper();

                if (atbilde == "N")
                {
                    return;
                }
            }
        }

        static void Sveiciens()
        {
            Console.WriteLine("Ka tevi sauc?");
            String SpeletajaVards = Console.ReadLine();
            Console.WriteLine("Sveiki {0}, uzspelesim so speli...", SpeletajaVards);
        }

        static void AppInfo()
        {
            String appName = "Uzmini manu skaitli!";
            String appVersion = "1.0.0";
            String appAuthor = "Felgiks";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        
        static void KrasainaAtbilde(ConsoleColor krasa, string teksts)
        {
            Console.ForegroundColor = krasa;
            Console.WriteLine(teksts);
            Console.ResetColor();
        }
    }
}
