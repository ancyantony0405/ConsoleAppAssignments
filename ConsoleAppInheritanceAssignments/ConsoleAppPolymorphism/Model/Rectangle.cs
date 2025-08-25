using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism.Model
{
    public class Rectangle : GeometricFigure
    {
        // Fields/Attributes
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Default constructor

        // Parameterized constructor

        // Methods to accept sides
        public override void Accept()
        {
            NoOfSides = 4;
            Console.WriteLine("Enter the length :");
            Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth :");
            Breadth = double.Parse(Console.ReadLine());
        }

        //Overriding method to display
        public override void Display()
        {
            Console.WriteLine($"Rectangle - Sides: {NoOfSides}, Length: {Length}, " +
                $"Breadth: {Breadth}");
        }

        // Overriding method to calculate area
        public override double Area()
        {
            return Length * Breadth;
        }
    }
}
