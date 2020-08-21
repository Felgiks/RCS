using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;

namespace Day6_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums1();
            //Uzdevums2();
            Uzdevums3();

        }
        static void Uzdevums1()
        {
            Console.WriteLine("Ievadiet masiva lielumu");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int[] Massivs1 = new int[x1];
            Random Randoms = new Random();
            
            for (int i = 0; i < Massivs1.Length; i++)
            {
                Massivs1[i] = Randoms.Next(0, 11);
                Console.WriteLine(Massivs1[i]);
            }
        }
        static void Uzdevums2()
        {
            int[] Massivs10 = new int[10];
            Random Randoms = new Random();

            for (int i = 0; i < Massivs10.Length; i++)
            {
                Massivs10[i] = Randoms.Next(0, 11);
                Console.WriteLine(Massivs10[i]);
            }
            Console.WriteLine("Ievadiet mekleto skaitli no 0 līdz 10");
            int Ievaditais = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Massivs10.Length; i++)
            {
                if (Ievaditais == Massivs10[i])
                {
                    Console.WriteLine("Jusu skitlis ir masiiva ar indexu " + Array.IndexOf(Massivs10, Ievaditais));
                }
            }
        }
        static void Uzdevums3()
        { 
            int[] Masiivs = new int[5];
            Masiivs[0] = 3;
            Masiivs[1] = 66;
            Masiivs[2] = 12;
            Masiivs[3] = 77;
            Masiivs[4] = 9;
            
            Console.WriteLine(Greatest(Masiivs));
        }
        static int Greatest(int[] Box)
        {
            int biggest = Box[0];
            for(int i = 0; i < Box.Length; i++) 
            {
                if(biggest < Box[i])
                {
                    biggest = Box[i];
                }
            }
            return biggest;
        }
    }
}
