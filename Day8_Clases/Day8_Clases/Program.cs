using System;
using System.Collections.Generic;

namespace Day8_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers.Test1();
            //Console.WriteLine(Tools.Kapinasana(4, 3)) ;
            List<int> Skaitli = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 13, 14, 32, 33};

            List<int> Rezultats = Tools.Nepara(Skaitli);

            foreach (var Neparis in Rezultats)
            {
                Console.WriteLine(Neparis);
            }
        }
    }
}
