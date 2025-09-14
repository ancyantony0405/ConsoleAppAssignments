using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutoParts.Model
{
    public class Parts
    {
        // Fields
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public ManufacturingCompany Company { get; set; }
        public List<Car> CompatibleCars { get; set; }

        public Parts(string code, string name, string category, double purchasePrice, double salePrice, ManufacturingCompany company)
        {
            Code = code;
            Name = name;
            Category = category;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            Company = company;
            CompatibleCars = new List<Car>();
        }

        public void AddCompatibleCar(Car car)
        {
            CompatibleCars.Add(car);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nPart Code: {Code}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Purchase Price: {PurchasePrice}, Sale Price: {SalePrice}");
            Company.DisplayInfo();

            Console.WriteLine("   Compatible Cars:");
            foreach (var car in CompatibleCars)
            {
                car.DisplayInfo();
            }
        }
    }
}