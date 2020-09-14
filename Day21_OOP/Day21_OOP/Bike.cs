using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_OOP
{
    class Bike : Vehicle
    {
        public Bike(String brand, String model) : base(brand, model)
        {

        }
        public override void Drive()
        {
            Console.WriteLine("Zumm zummm");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike has stoped");
        }
    }
}
