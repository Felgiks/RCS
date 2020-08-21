using System;
using System.Collections.Generic;

namespace Day7_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            Task4();
        }

        static void Task4()
        {
            List<int> rand = new List<int>();

            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                rand.Add(r.Next(11));
            }

            int[] result = ConvertToArray(rand);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        private static int[] ConvertToArray(List<int> rand)
        {
            int[] res = new int[rand.Count];

            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rand[i];
            }

            return res;
        }

        static void Task1()
        {
            int[] Massivs1 = new int[5];
            Massivs1[0] = 3;
            Massivs1[1] = 99;
            Massivs1[2] = 5;
            Massivs1[3] = 17;
            Massivs1[4] = 3;
            int[] Massivs2 = new int[5];
            Massivs2[0] = 3;
            Massivs2[1] = 99;
            Massivs2[2] = 42;
            Massivs2[3] = 77;
            Massivs2[4] = 3;

            Salidzinat(Massivs1, Massivs2);

        }
        static void Salidzinat<T>(T[] box1, T[] box2)
        {
            for (int i = 0; i < 6; i++)
            {
               // Console.WriteLine(box1.SequenceEqual(box2));
            }
        }

        static void Homework1()
        {
            Console.WriteLine("Ievadiet vertibas!");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] arrayOfRandom = new int[count];

            Random r = new Random();

            for (int i = 0; i < count; i++)
            {
                arrayOfRandom[i] = r.Next(11);
                Console.Write(arrayOfRandom[i] + " ");
            }

            Console.WriteLine();


        }

        static void Homework2()
        {
            int[] arrayOfRandom = new int[10];

            Random r = new Random();

            for (int i = 0; i < arrayOfRandom.Length; i++)
            {
                arrayOfRandom[i] = r.Next(11);
            }

            Console.WriteLine("Ievadiet skaitli, ko meklet!");
            int number = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            Console.WriteLine("Indeksi: ");
            for (int i = 0; i < arrayOfRandom.Length; i++)
            {
                if (arrayOfRandom[i] == number)
                {
                    Console.Write(i + " ");
                    found = true;
                }
            }

            if (!found) //found == false
            {
                Console.WriteLine("Nekas netika atrasts!");
            }
        }

        static void Homework3()
        {
            int[] arrayOfRandom = new int[10];

            Random r = new Random();

            for (int i = 0; i < arrayOfRandom.Length; i++)
            {
                arrayOfRandom[i] = r.Next(11);
            }

            Console.WriteLine(Biggest(arrayOfRandom));
        }

        static int Biggest(int[] arr)
        {
            int biggest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (biggest < arr[i])
                {
                    biggest = arr[i];
                }
            }

            return biggest;
        }

        static void Task2()
        {

            int[] a = { 1, 2, 99, 4, 5 };
            int[] b = { 1, 2, 3, 4, 5 };

            Console.WriteLine(CompareArr(a, b));
        }

        private static bool CompareArr(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }
        /*1) Izveidot metodi ConvertToArray, 
         * kas kā parametru paņem listu (listā ģenerēt random 5 vērtības) 
         * un ar return atgriež masīvu. 
          (Izmantot for ciklu, ne ToArray metodi) */
         static void Task3()
        {
            int[] Saraksts1 = GetNumbers(0, 6);
            int[] Saraksts2 = new int[5];
            List<int> list = new List<int>();
        }
        static int[] GetNumbers(int start, int end)
        {
            List<int> list = new List<int>();
            for (int i = start; i < end; i++)
                list.Add(i);
            return list.ToArray();
        }

    }


}