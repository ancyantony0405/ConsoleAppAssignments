using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism.Model
{
    public class GeometricFigure
    {
        // Common fields/attributes/properties
        public int NoOfSides { get; set; }

        // Default constructor
       
        // Parameterized constructor
      
        // Methods to accept side
        public virtual void Accept()
        {
            Console.WriteLine("Enter the number of sides :");
            NoOfSides = int.Parse(Console.ReadLine());
        }

        // Virtual method to display
        public virtual void Display()
        {
            Console.WriteLine($"Number of sides: {NoOfSides}");
        }

        // Virtual method to calculate area
        public virtual double Area()
        {
            return 0; // Default (not meaningful here)
        }
    }
}
