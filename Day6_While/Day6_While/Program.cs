using System;
using System.Diagnostics.CodeAnalysis;

namespace Day6_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhileMenu();
            //Task1();
            //ArraySample();
            Task2();
        }
        static void WhileMenu()
        {
            String Choise = "";

            while(Choise != "EXIT")
            {
                Console.WriteLine("1 iteracija pagajusi");
                Choise = Console.ReadLine();
                Choise.ToUpper(); //konvertejot jebkuru ievades veidu, galarezultata iegust "EXIT" no "eXiT"
            }

            do
            {
                Console.WriteLine("1 iteracija pagajusi");
                Choise = Console.ReadLine();
                Choise.ToUpper();
            } while (Choise != "EXIT");
        }

        static void Task1()
        {
            
           int SkaitluSumma = 0;

           while (true)
           {
                Console.WriteLine("ievadiet skaitli summas virknee");
                int Skaitlis = Convert.ToInt32(Console.ReadLine());
                SkaitluSumma = SkaitluSumma + Skaitlis;

                Console.WriteLine("Vai velaties sanemt summu? Y/N!");
                String Atbilde = Console.ReadLine();

                if (Atbilde.ToUpper() == "Y")
                {
                    Console.WriteLine(SkaitluSumma);
                    break;
                }
           }
        }
        static void ArraySample()
        {
            int[] MassivaNosaukums = new int[5]; //Ja garums ir n, tad pedeejais indeks ir n-1(saja gadijuma tas nus 4)
            MassivaNosaukums[0] = 3;
            MassivaNosaukums[1] = 99;
            MassivaNosaukums[2] = 12;
            MassivaNosaukums[3] = 77;
            MassivaNosaukums[4] = 9;

            for(int i = 0; i < MassivaNosaukums.Length; i++)
            {
                Console.WriteLine(MassivaNosaukums[i]);
            }

            foreach(int ArrayLine in MassivaNosaukums)
            {
                Console.WriteLine(ArrayLine);
            }

        }
        static void Task2()
        {
            string[] Massivs = new string[9];

            for(int i = 0; i < Massivs.Length; i++) 
            { 
            Massivs[i] = Console.ReadLine();
            }
            
            for (int i = 0; Massivs[i].Length > 5; i++)
            {
                Console.WriteLine(Massivs[i]);
            }

        }
    }
}
