using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPerson.Model
{
    public class Student : Person
    {
        public int RollNumber { get; set; }
        public int Marks { get; set; }

        //default constructor
        public Student()
        {
        }
        //parameterized constructor
        public Student(string name, int age, int rollNumber, int marks) : base(name, age)
        {
            RollNumber = rollNumber;
            Marks = marks;
        }

        //method to get student details
        public void Get_data()
        {
            base.Read_data();
            Console.Write("Enter Roll Number:");
            RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks:");
            Marks = Convert.ToInt32(Console.ReadLine());
        }

        //Compute grade based on marks
        public string Compute_Grade()
        {
            if (Marks >= 90)
                return "A";
            else if (Marks >= 80)
                return "B";
            else if (Marks >= 70)
                return "C";
            else if (Marks >= 60)
                return "D";
            else
                return "F";
        }

        //method to display student details
        public void Display_data()
        {
            base.Display_data(); 
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Marks: " + Marks);
            Console.WriteLine("Grade: " + Compute_Grade());
        }
    }
}
