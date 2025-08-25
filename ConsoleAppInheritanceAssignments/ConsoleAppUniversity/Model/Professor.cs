using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUniversity.Model
{
    public class Professor
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public string Major { get; set; }
        // Default constructor
        public Professor()
        {
        }
        // Parameterized constructor
        public Professor(string name, int employeeId, string major)
        {
            Name = name;
            EmployeeId = employeeId;
            Major = major;
        }
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching in the {Major}");
        }
        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name : {Name}");
            sb.AppendLine($"Employee ID : {EmployeeId}");
            sb.AppendLine($"Major : {Major}");
            return sb.ToString();
        }
    }
}
