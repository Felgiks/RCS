using System;
using System.Collections.Generic;
using System.Text;

namespace MacosProgrammet1
{
    class MajasDarbs
    {
        public static void Homework3()
        {
            int[] RandMass = new int[50];
            Random Rand = new Random();

            for (int i = 0; i < RandMass.Length; i++)
            {
                RandMass[i] = Rand.Next(51);
            }

            Console.WriteLine(Lielaakais(RandMass));
        }
        public static int Lielaakais(int[] Masiivs)
        {
            int Biggest = Masiivs[0];
            for (int i = 0; i < Masiivs.Length; i++)
            {
                if (Biggest < Masiivs[i])
                {
                    Biggest = Masiivs[i];
                }
            }
            return Biggest;
        }
        public static void Homework2()
        {
            int[] RandMasiivs = new int[50];
            Random Rand = new Random();

            for (int i = 0; i < RandMasiivs.Length; i++)
            {
                RandMasiivs[i] = Rand.Next(21);
            }

            Console.WriteLine("Kadu skaitli gribat meklet?");
            int Mekleejamais = Convert.ToInt32(Console.ReadLine());

            foreach (int a in RandMasiivs)
            {
                Console.WriteLine(a + " ");
            }

            bool Found = false;

            for (int i = 0; i < RandMasiivs.Length; i++)
            {
                if (RandMasiivs[i] == Mekleejamais)
                {
                    Console.WriteLine("Index - " + i + " ar vetrtibu = " + Mekleejamais);
                    Found = true;
                }
            }
            if (!Found)
            {
                Console.WriteLine("Jusu skaitlis nav masiivaa");
            }
        }

        public static void Homework1()
        {
            Console.WriteLine("ievadiet skaitli");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] RandomMasiivs = new int[count];
            Random RandomCipari = new Random();

            for (int i = 0; i < count; i++)
            {
                RandomMasiivs[i] = RandomCipari.Next(11);
                Console.Write(RandomMasiivs[i] + " ");
            }

            Console.WriteLine();
        }

    }
}
