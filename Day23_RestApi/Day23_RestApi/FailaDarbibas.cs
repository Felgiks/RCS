using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Day23_RestApi
{
    class FailaDarbibas
    {
        public static List<Student> LasitFailu(String filename)
        {
            String line;
            List<Student> StringList = new List<Student>();
            try
            {
                StreamReader sr = new StreamReader(filename);
                line = sr.ReadLine();

                while (line != null)
                {
                    // neaizmirsti validet input / nolasito pirms izmanto talak
                    String temp = sr.ReadLine();
                    if (temp != null && !temp.Equals(""))
                    {
                        line = temp;
                    }
                    else
                    {
                        break;
                    }
                }
                StringList = JsonConvert.DeserializeObject<List<Student>>(line);
                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu:" + filename);
                Environment.Exit(0);
            }
            return StringList;
        }
        public static void RakstitFailu(String stringLst, String filename)
        {
            try
            {
                StreamWriter Rakstitaajs = new StreamWriter(filename);
                Rakstitaajs.WriteLine(stringLst);
                Rakstitaajs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }

    }
}
