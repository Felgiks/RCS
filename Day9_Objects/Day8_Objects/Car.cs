using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_Objects
{
    class Car
    {
        public String color;
        public String brand;
        public String model;

        public Car(String localColor, String localBrand, String localModel)
        {
            this.color = localColor;
            this.brand = localBrand;
            this.model = localModel;
        }
        public void PrintInfo()
        {
            Console.WriteLine(color + "" + brand + "" + model);
        }
    }
}
