﻿using Newtonsoft.Json;
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

        public Student(String Name, String LastName, int Age)
        {
            this.name = Name;
            this.lastName = lastName;
            this.course = Age;
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
