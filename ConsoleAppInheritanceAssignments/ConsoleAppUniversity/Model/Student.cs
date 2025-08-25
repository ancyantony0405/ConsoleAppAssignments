using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUniversity.Model
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public string Major { get; set; }

        // Default constructor
        public Student()
        {

        }

        // Parameterized constructor
        public Student(string name, int studentId, string major)
        {
            Name = name;
            StudentId = studentId;
            Major = major;
        }

        public void study()
        {
            Console.WriteLine($"{Name} is studying as a {Major} student");
        }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Student ID: {StudentId}");
            sb.AppendLine($"Major: {Major}");
            return sb.ToString();
        }
    }
}
