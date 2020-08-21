using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Day4_If1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //OtraisUzdevums();
            //OtraisUzdevumsExtra();
            //Task2();
            //Task3();
            //Task4();
            //Task4Skolotajs();
            //Task5();
            //BoolSample();
            //Task6();
            //Task7();

        }
        static void Task1()
        {
            Console.WriteLine("Ievadiet skaitli!");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Skaitlis ir 0!");
            }
            else if (number > 0)
            {
                Console.WriteLine("Skaitlis ir pozitivs,tapat ka TU!");
            }
            else
            {
                Console.WriteLine("Skailis ir negativs :(");
            }

        }
        static void OtraisUzdevums()
        {
            Console.WriteLine("Ievadiet pirmo skaitli!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli!");
            int b = Convert.ToInt32(Console.ReadLine());

            Salidzinatajs(a, b);

        }
        static void Salidzinatajs(int a, int b)
        {
            if (a > b) { Console.WriteLine(a); }
            else Console.WriteLine(b);
        }
        static void OtraisUzdevumsExtra()
        {

            Console.WriteLine("Ievadiet pirmo skaitli!");
            int a = Convert.ToInt32(Console.ReadLine());
            bool VaiIrPozitivs = false;
            VaiIr(a);

        }
        static bool VaiIr(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("Skaitlis ir pozitivs!");
                return true;
            }
            else
            {
                Console.WriteLine("Skaitlis ir negativs!");
                return false;
            }

        }
        static void Task2()
        {
            CompareNumbers(324, 16632);
        }
        static void CompareNumbers(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Lielaks ir " + a);
            }
            else if (a < b)
            {
                Console.WriteLine("Lielaks ir " + b);
            }
            else
            {
                Console.WriteLine("Skaitli ir vienadi");
            }
        }
        static void Task3()
        {
            int a = Convert.ToInt32(Console.ReadLine());


            if (a > 0 && a < 10)
            {
                Console.WriteLine("Skaitlis ir diapazona no 1 lidz 10");
            }
            else
            {
                Console.WriteLine("Skaitlis nav diapazona");
            }
        }
        static void Task4()
        {
            string Skaitlis1 = Ievade();
            string Skaitlis2 = Ievade();
            int Num1 = Convert.ToInt32(Skaitlis1);
            int Num2 = Convert.ToInt32(Skaitlis2);
            int Garums = Skaitlis1.Length; //sadi tiem merits stringa garums
            int Garums2 = Skaitlis2.Length;
            if (Garums == Garums2)
            { Console.WriteLine("Garums ir vienads");
                if (Num1 > Num2)
                {
                    Console.WriteLine("Pirmais skaitlis ir lielaks");
                }
                else Console.WriteLine("Otrais skaitlis ir lielaks");
            }
            else
            {
                Console.WriteLine("Nav vienads garums!");
            }
        }
        static string Ievade()
        {
            Console.WriteLine("Ievadiet jebkadu skaitli");
            return Console.ReadLine();


        }
        static void Task4Skolotajs()
        {
            Console.WriteLine("ievadiet skaitli");
            string a1 = Console.ReadLine();
            Console.WriteLine("ievadiet skaitli");
            string b2 = Console.ReadLine();

            if (a1.Length == b2.Length)
            {
                CompareNumbers(Convert.ToInt32(a1), Convert.ToInt32(b2));
            }
            else
            {
                Console.WriteLine("Simbolu skaits nav vienads");
            }

        }
        static void Task5()
        {
            OddOrEven(5);
        }
        static void OddOrEven(int number)
        {
            if (number % 2 > 0)
            {
                Console.WriteLine("Nepāra skaitlis");
            }
            else
            { Console.WriteLine("Pāra skaitlis"); }
        }
        static void BoolSample()
        {
            bool a = true;
            a = false;

            Console.WriteLine("Ievadiet skaitli!");
            int n = Convert.ToInt32(Console.ReadLine());

            bool even = IsEven(n);

            if (even == true) { Console.WriteLine(n); }
        }
        static bool IsEven(int number)
        {
            if (number % 2 > 0)
            {
                return false;
            }
            else
            { return true; }
        }
        static void Task6()
        {
            string Teikums = "Šis ir ievadītais teikums";
            StringLength(Teikums);
        }
        static bool StringLength(string value)
        {
            if (value.Length > 5 || value.Length < 15)
            { return true; }
            else { return false; }
        }
        static void Task7()
        {
            Skirotajs(44, 6, 6);

        }
        static void Skirotajs(int a, int b, int c)
        {
            
                if (a >= b && a >= c)
                {
                    Console.WriteLine("Lielakais ir " + a);
                }
                else if (b >= a && b >= c)
                {
                    Console.WriteLine("Lielakais ir " + b);
                }
                else
                {
                    Console.WriteLine("Lielakais ir " + c);
                }
            


        }
    }
}
