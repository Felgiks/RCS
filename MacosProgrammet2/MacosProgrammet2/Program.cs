using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MacosProgrammet2
{
    class Program
    {
        static void Main(string[] args)
        { 
           // IerakstitSarakstu();
            NolasitSarakstu();
        }
        static void IerakstitSarakstu()
        {
            List<Student> SkolenuSaraksts = new List<Student>();

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Ievadiet Vardu");
                String Vards = Console.ReadLine();
                Console.WriteLine("Ievadiet Uzvardu");
                String Uzvards = Console.ReadLine();
                Console.WriteLine("Ievadiet kursu");
                int Kurss = Convert.ToInt32(Console.ReadLine());

                SkolenuSaraksts.Add(new Student(Vards, Uzvards, Kurss));
            }
            FileOperations.RakstitStudentuSarakstu(SkolenuSaraksts, "skoleni.txt");
        }
        static void NolasitSarakstu()
        {
            List<Student> CitsSaraksts = FileOperations.LasitStudentuSarakstu("skoleni.txt");

            foreach (Student student in CitsSaraksts)
            {
                student.PrintInfo();
            }
        }
    }
}
