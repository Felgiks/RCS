using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day11_StudentIO
{
    class Program
    {
        static void Main(string[] args)
        {
            String filename = "C:\\Users\\Arturs Feldmanis\\Desktop\\SkoleniA.txt";

            //IzveidotSarakstu(filename);
            LasitSarakstu(filename);

        }

        private static void LasitSarakstu(String filename)
        {
            List<String> SkolSarakstsB = FailaDarbibas.LasitFailu(filename);

            foreach (String a in SkolSarakstsB)
            {
                Console.WriteLine(a);
            }

        }

        static void IzveidotSarakstu(String filename)
        {
            List<Student> SkolSarakstsA = new List<Student>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet vardu");
                String name = Console.ReadLine();

                Console.WriteLine("Ievadiet uzvardu");
                String lastName = Console.ReadLine();

                Console.WriteLine("Ievadiet kursu");
                int coarse = Convert.ToInt32(Console.ReadLine());

                SkolSarakstsA.Add(new Student(name, lastName, coarse));
            }

            FailaDarbibas.RakstitFailu(SkolSarakstsA, filename);

        }
    }
}
