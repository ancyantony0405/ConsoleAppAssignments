using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate.Model
{
    public class House : Estate
    {
        public double DevelopedArea { get; set; }
        public double YardArea { get; set; }
        public int Floors { get; set; }
        public bool IsFurnished { get; set; }

        public House(double area, double pricePerSqm, string location, double developedArea, double yardArea, int floors, bool isFurnished)
            : base(area, pricePerSqm, location)
        {
            DevelopedArea = developedArea;
            YardArea = yardArea;
            Floors = floors;
            IsFurnished = isFurnished;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"House in {Location}, {Area} sqm, Price/m²: {PricePerSqm}, Developed: {DevelopedArea} sqm, Yard: {YardArea} sqm, Floors: {Floors}, Furnished: {IsFurnished}");
        }
    }
}
