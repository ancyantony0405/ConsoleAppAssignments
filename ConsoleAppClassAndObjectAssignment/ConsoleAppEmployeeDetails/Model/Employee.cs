using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployeeDetails.Model
{
    //Fields: name(string), baseSalary(double), yearsOfService(int)
    public class Employee
    {
        public string name;
        public double baseSalary;
        public int yearsOfService;

        // Default constructor
        public Employee()
        {
            name = "Unknown";
            baseSalary = 0.0;
            yearsOfService = 0;
        }

        // Parameterized constructor

        //methods
        //CalculateBonus() → Bonus is baseSalary * 0.05 * yearsOfService
        public double CalculateBonus()
        {
            return baseSalary * 0.05 * yearsOfService;
        }

        //TotalSalary() → baseSalary + bonus
        public double TotalSalary()
        {
            return baseSalary + CalculateBonus();
        }

        //ToString()
        public override string? ToString()
        {
            return $"Employee: {name}, Base Salary: {baseSalary}, " +
                   $"Years of Service: {yearsOfService}, " +
                   $"Bonus: {CalculateBonus()}, " +
                   $"Total Salary: {TotalSalary()}";
        }
    }
}
