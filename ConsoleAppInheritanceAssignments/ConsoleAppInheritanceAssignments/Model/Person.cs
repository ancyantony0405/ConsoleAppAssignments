using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPerson.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //default constructor
        public Person()
        {
            
        }

        //parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //method to get person details
        public void Read_data()
        {
            Console.Write("Enter Name:");
            Name = Console.ReadLine();
            Console.Write("Enter Age:");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        //method to display person details
        public void Display_data()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
