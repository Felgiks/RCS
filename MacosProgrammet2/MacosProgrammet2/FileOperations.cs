using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MacosProgrammet2
{
    class FileOperations
    {
        public static List<Student> LasitStudentuSarakstu(String filename)
        {
            String line;
            List<Student> SkolenuSaraksts = new List<Student>();
            try
            {
                StreamReader Lasiitaajs = new StreamReader(filename);

                line = Lasiitaajs.ReadLine();

                while (line != null)
                {
                    String[] NoFaila = line.Split(",");
                    SkolenuSaraksts.Add(new Student(NoFaila[0], NoFaila[1], Convert.ToInt32(NoFaila[2])));

                    line = Lasiitaajs.ReadLine();
                }

                Lasiitaajs.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
                Environment.Exit(0);
            }

            return SkolenuSaraksts;
        }

        public static void RakstitStudentuSarakstu(List<Student> SkolenuSaraksts, String FailaNosaukums)
        {
            try
            {
                StreamWriter sw = new StreamWriter(FailaNosaukums);

                foreach (Student st in SkolenuSaraksts)
                {
                    sw.WriteLine(st.Vards + "," + st.Uzvards + "," + st.Kurss);
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
