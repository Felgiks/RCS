using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Day13_MoreGUI
{
    class FailaDarbibas
    {
            public static List<String> ReadList(String filename)
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

            public static void WriteList(ListView ElementList, String filename)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(filename);

                    foreach (ListViewItem n in ElementList.Items)
                    {
                        sw.WriteLine(n.Text);
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

