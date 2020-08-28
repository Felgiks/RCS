using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_JSON
{
    class Student
    {
        public String name;
        public String lastName;
        public int course;

        public Student(String name, String lastName, int course)
        {
            this.name = name;
            this.lastName = lastName;
            this.course = course;
        }

        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(lastName);
            Console.WriteLine(course);
        }
    }
}
