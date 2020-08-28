using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_JSON
{
    class Auto
    {
        public String brand;
        public String model;
        public String colour;
        public int year;
        public int power;
        public int price;
        public bool IsSold;

        public Auto(String brand, String model, String colour, int year, int power, int price, bool IsSold)
        {
            this.brand = brand;
            this.model = model;
            this.colour = colour;
            this.year = year;
            this.power = power;
            this.price = price;
            this.IsSold = IsSold;
        }

        public void PrintInfo()
        {
            Console.WriteLine(brand + " " + model + " " + colour + " " + year + " " + power + " " + price);
        }
    }
}
