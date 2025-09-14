using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate.Model
{
    public class UndevelopedArea : Estate
    {
        public UndevelopedArea(double area, double pricePerSqm, string location)
            : base(area, pricePerSqm, location) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Undeveloped land in {Location}, {Area} sqm, Price/m²: {PricePerSqm}");
        }
    }
}
