using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_OOP
{
    abstract class Vehicle
    {
        public String Brand { get; set; }

        protected String Model { get; set; }
        public abstract void Stop();
        
        public Vehicle(String brand, String model)
        {
            Brand = brand;
            Model = model;
        }
        public virtual void Drive()
        {
            Console.WriteLine("Brum,Brum");
        }
    }
}
