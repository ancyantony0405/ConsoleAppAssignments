using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutoParts.Model
{
    public class Car
    {
        // Fields
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // Method to display car info
        public void DisplayInfo()
        {
            Console.WriteLine($"   Car: {Brand} {Model}, Year: {Year}");
        }
    }
}