using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate.Model
{
    public class Apartment : Estate
    {
        public int Floor { get; set; }
        public bool HasElevator { get; set; }
        public bool IsFurnished { get; set; }

        public Apartment(double area, double pricePerSqm, string location, int floor, bool hasElevator, bool isFurnished)
            : base(area, pricePerSqm, location)
        {
            Floor = floor;
            HasElevator = hasElevator;
            IsFurnished = isFurnished;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Apartment in {Location}, {Area} sqm, Price/m²: {PricePerSqm}, Floor: {Floor}, Elevator: {HasElevator}, Furnished: {IsFurnished}");
        }
    }
}


