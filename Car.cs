using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    internal class Car
    {
        public string Brand;
        public string Color;
        public int MaxSpeed;

        public void ShowInfo()
        {
            Console.WriteLine($"Carinfo: {Brand}, {Color}, MaxSpeed: {MaxSpeed}");
        }
        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }
    }
}
