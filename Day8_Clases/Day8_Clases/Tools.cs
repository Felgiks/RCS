using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_Clases
{
    class Tools
    {
        public static int Kapinasana(int a, int b)
        {
            int Rezult = a;
            for (int i = 0; i < b; i++)
            {
                Rezult *= a;
            }
            return Rezult;
        }
        public static List<int> Nepara(List<int> Saraksts)
        {
            List<int> NepararaList = new List<int>();

            for (int i = 0; i < Saraksts.Count; i++)
            {
                if (Saraksts[i] % 2 == 1)
                {
                    NepararaList.Add(Saraksts[i]);
                }
            }

            return NepararaList;
        }
    }
}
