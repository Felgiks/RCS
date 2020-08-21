using System;

namespace Day3_MajasDarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            PirmaisUzdevums();
            OtraisUzdevums();
            TresaisUzdevums();
            CeturtaisUzdevums();
        }
        static void PirmaisUzdevums()
        {
            Console.WriteLine("Ievadiet skaitli!");
            int KasJaakaapina = Convert.ToInt32(Console.ReadLine());
            Kvadraataa(KasJaakaapina, KasJaakaapina);

        }
        static void Kvadraataa(int a, int b)
        {
            Console.WriteLine("Skaitlis kvadrataa = " + (a * b));
        }
        static void OtraisUzdevums()
        {
            double num1 = OtraIevade();
            Console.WriteLine("Jusu ievaditais skaitlis = " + num1);
        }
        static double OtraIevade()
        {
            Console.WriteLine("Ievadiet skaitli ar komatu!");
            return Convert.ToDouble(Console.ReadLine());
        }
        static void TresaisUzdevums()
        {
            double num1 = OtraIevade();
            Console.WriteLine("Jusu ievadijat = " + num1 + ", bet rezultats ir = " + (num1 - 2));
        }
        static void CeturtaisUzdevums()
        {
            Console.WriteLine("Ievadiet simbolu virkni 1!");
            string a = Console.ReadLine();
            Console.WriteLine("Ievadiet simbolu virkni 2!");
            string b = Console.ReadLine();
            Console.WriteLine("Ievadiet simbolu virkni 3!");
            string c = Console.ReadLine();
            Samainisana(a, b, c);
        }  
        static void Samainisana(string a, string b, string c)
        {
            Console.WriteLine(c + b + a);
            return;
        }
    }
}
