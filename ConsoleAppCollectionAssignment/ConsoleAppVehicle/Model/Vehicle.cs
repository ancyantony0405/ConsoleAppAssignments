using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVehicle.Model
{
    public class Vehicle
    {
        // Fields
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Override ToString() for easy display
        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    }
}
