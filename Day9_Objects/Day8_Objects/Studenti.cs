using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_Objects
{
    class Studenti
    {

        public String Name;
        public String Surename;
        public int Year;
        public Studenti(String localName, String localSurename, int localYear)
        {
            this.Name = localName;
            this.Surename = localSurename;
            this.Year = localYear;
        }

        public void PrintInfoStudent()
        {
            Console.WriteLine(Name + " " + Surename + " " + Year);
        }
    }
}
