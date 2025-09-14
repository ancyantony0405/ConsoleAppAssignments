using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate.Model
{
    public abstract class Estate
    {
        public double Area { get; set; }
        public double PricePerSqm { get; set; }
        public string Location { get; set; }

        protected Estate(double area, double pricePerSqm, string location)
        {
            Area = area;
            PricePerSqm = pricePerSqm;
            Location = location;
        }

        public abstract void DisplayInfo();
    }
}
