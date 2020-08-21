using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Text;

namespace Day10_FileIO
{
    class Sample
    {
        public static void Read()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("Test.txt");

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
            }
        }

        public static void Write()
        {
            try
            {  //Noraadot faila vietu, sliipsviitru "/" raksta dubultaa -"//" vai pieliekam "@" pirms vietas noraades
                // ("C:\\Users\\Marti\\Desktop\\Test.txt"); vai (@"C:\Users\Marti\Desktop\Test.txt");
                StreamWriter sw = new StreamWriter("Test.txt", true);

                // True = norada, ka veidojot failu tas neparrakstiis iepriekseejo info, bet pierakstiis jauno rindinu
                
            
                sw.WriteLine("Hello");
                sw.WriteLine("from the other side!");

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
         
    }
}
