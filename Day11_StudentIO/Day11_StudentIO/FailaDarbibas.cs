using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day11_StudentIO
{
    class FailaDarbibas
    {
        public static List<Student> LasitFailu(String filename)
        {
            String line;
            List<Student> stringLst = new List<Student>();
            try
            {
                StreamReader sr = new StreamReader(filename);
                line = sr.ReadLine();

                while (line != null)
                {
                    String[] fromFile = line.Split(",");
                    stringLst.Add(new Student(fromFile[0], fromFile[1], Convert.ToInt32(fromFile[2])));

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
        public static void RakstitFailu(List<String> stringLst, String filename)
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
