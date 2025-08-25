using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUniversity.Model
{
    public class Course
    {
        public string title { get; set; }
        public int duration { get; set; }

        // Default constructor
        public Course()
        {
        }

        // Parameterized constructor
        public Course(string title, int duration)
        {
            this.title = title;
            this.duration = duration;
        }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Title: {title}");
            sb.AppendLine($"Duration: {duration} days");
            return sb.ToString();
        }
    }
}
