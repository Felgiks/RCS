using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day15_JSON
{
    class FailaDarbibas
    {
        public static List<Auto> LasitFailu(String filename)
        {
            String line;
            List<Auto> stringLst = new List<Auto>();
            try
            {
                StreamReader sr = new StreamReader(filename);
                line = sr.ReadLine();

                while (line != null)
                {
                    String[] fromFile = line.Split(",");
                    stringLst.Add(new Auto(fromFile[0], fromFile[1], fromFile[2], Convert.ToInt32(fromFile[3]), 
                        Convert.ToInt32(fromFile[4]), Convert.ToInt32(fromFile[5]), Convert.ToBoolean(fromFile[6])));


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
