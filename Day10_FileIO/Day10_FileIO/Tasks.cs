using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day10_FILEIO
{
    class Tasks
    {
        public static List<int> ReadNumbers(String filename)
        {
            String line;
            List<int> numbers = new List<int>();
            try
            {
                StreamReader sr = new StreamReader(filename);

                line = sr.ReadLine();

                while (line != null)
                {
                    numbers.Add(Convert.ToInt32(line));
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
            }

            return numbers;
        }

        public static void WriteNumbers(List<int> numbers, String filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);

                foreach (int n in numbers)
                {
                    sw.WriteLine(n);
                }
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
        public static List<String> ReadTekst(String filename)
        {
            String line;
            List<String> Teksts = new List<String>();
            try
            {
                StreamReader sr = new StreamReader(filename);

                line = sr.ReadLine();

                while (line != null)
                {
                    Teksts.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
            }

            return Teksts;
        }
        public static void WriteText(List<String> Teksts, String filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);

                foreach (String n in Teksts)
                {
                    sw.WriteLine(n);
                }
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }

    }
}