using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMaths.Model
{
    public class Maths
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        //default constructor
        public Maths()
        {
            
        }

        //parameterized constructor
        public Maths(double firstNumber, double secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        // Method to add two numbers
        public double Add()
        {
            return FirstNumber + SecondNumber;
        }

        // Method to subtract two numbers
        public double Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        // Method to multiply two numbers
        public double Multiply()
        {
            return FirstNumber * SecondNumber;
        }
        
        // Method to divide two numbers
        public double Divide()
        {
            return FirstNumber / SecondNumber;
        }
        //methods to accept two numbers and perform operations
        public void AcceptNumbers()
        {
            Console.Write("Enter the first number: ");
            FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            SecondNumber = Convert.ToDouble(Console.ReadLine());
        }

    }
}
