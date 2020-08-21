using System;
using System.Security.Cryptography.X509Certificates;

namespace Day4_MD
{
    class Program
    { 
        static void Main(string[] args)
        {  bool ON = true;
            while (ON)
            {
                Apps();
            }
        }
        static void Apps()
        {
            Console.WriteLine("Ievadiet pirmo skaitli!");
            double Num1 = Ievade();

            Console.WriteLine("Ievadiet otro skaitli!");
            double Num2 = Ievade();

            int Num3 = Piedavajums();
            Atbilde(Num1, Num2, Num3);
        }
        static double Ievade()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        static int Piedavajums()
        {
            Console.WriteLine("Kādu darbību veikt ar skaitļiem?(ievadiet skaitli kā atbildi)");
            Console.WriteLine("1-Saskaitī");
            Console.WriteLine("2-Atņemt");
            Console.WriteLine("3-Reizināt");
            Console.WriteLine("4-Dalīt");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Atbilde(double a, double b, int c)
        {
          int caseSwitch = c;
          switch (caseSwitch)
                {
                case 1:
                Console.WriteLine("Summa = " + (a + b));
                    break;
                case 2:
                Console.WriteLine("Starpība = " + (a - b));
                    break;
                case 3:
                Console.WriteLine("Reizinājums = " + (a * b));
                    break;
                case 4:
                Console.WriteLine("Dalījums = " + (a / b));
                    break;
                default:
                Console.WriteLine("Atbildi nesapratu,ludzu, atkārto!" + Piedavajums());
                    break;
                }
        }
        
    }
}
