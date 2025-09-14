using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutoParts.Model
{
    public class ManufacturingCompany
    {
        // Fields
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        // Constructor
        public ManufacturingCompany(string name, string country, string address, string phone, string fax)
        {
            Name = name;
            Country = country;
            Address = address;
            Phone = phone;
            Fax = fax;
        }

        // Method to display company info
        public void DisplayInfo()
        {
            Console.WriteLine($"   Manufacturer: {Name}, {Country}");
            Console.WriteLine($"   Address: {Address}, Phone: {Phone}, Fax: {Fax}");
        }
    }
}