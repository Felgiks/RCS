using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;

namespace Day23_Still_REST
{
    class Student
    {
        public String Name { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        public Student(String name, String lastName, int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }
        public override String ToString()
        {
            return Name + " " + LastName + ", " + Age;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
        }
    }
}
