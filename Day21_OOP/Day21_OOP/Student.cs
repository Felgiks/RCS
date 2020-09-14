using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_OOP
{
    class Student
    {
        private String Name;
        public String LastName { get;/*private*/ set; }
        private int _course; //"backing field"
        public int Course
        {
            get { return _course; }
            set
            {
                if (value >= 1 && value <= 3)
                {
                    _course = value;
                }
                else if(value > 3)
                {
                    _course = 3;
                }
                else
                {
                    _course = 1;
                }
            }
        }
        public Student(String name, String lastName, int course)
        {
            Name = name;
            LastName = lastName;
            Course = course;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(String name)
        {
            Name = name;
        }
        public void PrintInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(LastName);
            Console.WriteLine(Course);
        }
    }
}

