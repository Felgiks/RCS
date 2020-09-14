using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_OOP
{
    class Car : Vehicle
    {
        public int WheelCount { get; set; }
        public Car(String brand, String model, int wheelCount) : base(brand, model)
        {
            WheelCount = wheelCount;
            Console.WriteLine(this.Model);
        }
        public Car() : base("NOname", "NOname")
        {
            WheelCount = 4;
        }

        public override void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
    }
}
