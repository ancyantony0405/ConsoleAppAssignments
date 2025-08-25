using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployee.Model
{
    public class Employee
    {
        public int EmployeeNo { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public double BasicPay { get; set; }

        // Default constructor
        public Employee()
        {

        }

        // Parameterized constructor
        public Employee(int employeeNo, string name, string designation, double basicPay)
        {
            EmployeeNo = employeeNo;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        // Method to get employee details
        public virtual string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employee No: {EmployeeNo}");
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Designation: {Designation}");
            sb.AppendLine($"Basic Pay: {BasicPay}");
            return sb.ToString();

        }
    }
}
