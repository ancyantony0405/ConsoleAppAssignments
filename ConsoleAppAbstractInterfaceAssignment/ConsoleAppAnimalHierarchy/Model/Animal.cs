using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalHierarchy.Model
{
    public abstract class Animal
    {
        // Field
        public int NoOfLegs { get; set; }
        public string Color { get; set; }

        // Constructor
        public Animal(int noOfLegs, string color)
        {
            NoOfLegs = noOfLegs;
            Color = color;
        }

        // Abstract methods (must be implemented by derived classes)
        public abstract string Cry();
        public abstract string Fly();
        public abstract void Walk();
    }
}
