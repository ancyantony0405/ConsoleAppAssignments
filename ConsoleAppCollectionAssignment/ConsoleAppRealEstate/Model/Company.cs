using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRealEstate.Model
{
    public class Company
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string TaxId { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Estate> Estates { get; set; }

        public Company(string name, string owner, string taxId)
        {
            Name = name;
            Owner = owner;
            TaxId = taxId;
            Employees = new List<Employee>();
            Estates = new List<Estate>();
        }

        public void AddEmployee(Employee emp) => Employees.Add(emp);
        public void AddEstate(Estate estate) => Estates.Add(estate);

        public void DisplayInfo()
        {
            Console.WriteLine($"Company: {Name}, Owner: {Owner}, Tax ID: {TaxId}");
            Console.WriteLine("Employees");
            foreach (var emp in Employees) emp.DisplayInfo();

            Console.WriteLine("Estates for Sale");
            foreach (var estate in Estates) estate.DisplayInfo();
        }
    }
}