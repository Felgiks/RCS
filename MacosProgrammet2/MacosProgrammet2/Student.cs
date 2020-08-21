using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MacosProgrammet2
{
    class Student
    {
        public String Vards;
        public String Uzvards;
        public int Kurss;

        public Student(String name, String lastName, int course)
        {
            this.Vards = name;
            this.Uzvards = lastName;
            this.Kurss = course;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Vards);
            Console.WriteLine(Uzvards);
            Console.WriteLine(Kurss);
        }
    }
}
