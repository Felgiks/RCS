using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Day5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoopSample();
            //LoopSample2();
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //nukkas();
            MD();
        }
        static void LoopSample()
        {
            
            for (int i = 1; i < 5; i++)
            {
               Veidenbaums();

            }
            //cikli - for, while, do..while
            //i++ = i=i+1
            //i-- = i=i-1
            //i+=4  i=i+4

        }
        static void Veidenbaums()
        {
            Console.WriteLine("Ka gulbji balti padebesi iet");
            Console.WriteLine("Tiem gribetos vel lidzi talu skriet");
            Console.WriteLine("Tur taluma, tur ziemas nepazist");
            Console.WriteLine("Tur rozes zied un muzam nenovist");
        } //atcerieties par sakuma un beigu iekavam!
        static void LoopSample2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Task1()
        {

            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + i + " ");

            }
            Console.WriteLine();
        }
        static void Task2()
        {
            int Num = 0;

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("ievadiet " + i + ",skaitli !");
                int number = Convert.ToInt32(Console.ReadLine());
                Num += number;
               
            }
            

        }
        static void Task3()
        {
            Console.WriteLine("ievadiet skaitli !");
            int n = Convert.ToInt32(Console.ReadLine());
            int min = n;
            int max = n;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                n = Convert.ToInt32(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine("Max =" + max);
            Console.WriteLine("Min =" + min);
        }
        static void Task4()
        {
            int Start = 0;
            String Aa = "*";
            for (int i = 1; i < 5; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write(Aa);
                }
                Console.WriteLine();

                
            }
            for (int i = 5; 1 <= i; i--)
            {
                for (int b = 1; b < i; b++)
                {
                    Console.Write(Aa);
                }
                Console.WriteLine();
            }
        }
        static void nukkas()
        {
          double sum = 0.0;
          Console.WriteLine("Enter number, -1 to stop!"); ;
          do
          {
           string Input = Console.ReadLine();
           double Skaitlis = double.Parse(Input);
           if (Skaitlis < 0) break;
          } while (true);
          Console.WriteLine("summa = " + sum);
        }
        static void MD()
        { int reizes = 7; //nebija idejas ar ko salīdzināt
            
            do
            {
                Console.WriteLine("\n" + "Ievadiet skaitli!");
                int Skaitlis = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n" + "Ievadiet kaapinataaju!");
                int Kāpinātājs = Convert.ToInt32(Console.ReadLine());
                 
                int Summ = MajasDarbs(Skaitlis, Kāpinātājs);
                Console.WriteLine("\n" + "  " + Kāpinātājs);
                Console.WriteLine(Skaitlis + "  " + "= " + Summ + "\n");
            } while (reizes > -10);
        }
        static int MajasDarbs(int Skai, int Kaap)
        {
            int sum = Skai;
            for (int a = 0; a < Kaap; a++)
            {
             sum *= Skai;
            }
            return sum;
        }
    } 
}
