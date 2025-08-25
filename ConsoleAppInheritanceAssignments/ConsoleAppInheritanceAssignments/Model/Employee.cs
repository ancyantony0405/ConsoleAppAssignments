using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPerson.Model
{
    public class Employee : Person
    {
        public double BP { get; set; }
        public double HR { get; set; }
        public double salary { get; set; }

        //default constructor
        public Employee() 
        {

        }
        //parameterized constructor

        public Employee(string name, int age, double bp, double hr) : base(name, age)
        {
            BP = bp;
            HR = hr;
        }
        
        //method to get data
        public void Get_data()
        {
            base.Read_data();
            Console.WriteLine("Enter Basic Pay : ");
            BP = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the HR : ");
            HR = Convert.ToDouble(Console.ReadLine());
        }

        //method to compute salary
        public void ComputeSalary()
        {
            salary = BP + HR;
        }

        //method to display employee details
        public void Display_data()
        {
            base.Display_data();
            Console.WriteLine("Basic Pay: " + BP);
            Console.WriteLine("HR: " + HR);
            Console.WriteLine("Salary: " + salary);
        }
    }
}
