using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day11_HomeWork
{
    class FileOperations
    {
        public static List<String> ReadStringLst(String filename)
        {
            String line;
            List<String> stringLst = new List<String>();
            try
            {
                StreamReader sr = new StreamReader(filename);

                line = sr.ReadLine();

                while (line != null)
                {
                    stringLst.Add(line);

                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
                Environment.Exit(0);
            }

            return stringLst;
        }

        public static void WriteStringLst(List<String> stringLst, String filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);

                foreach (String n in stringLst)
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
