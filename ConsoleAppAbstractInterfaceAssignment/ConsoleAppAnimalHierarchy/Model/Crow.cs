using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalHierarchy.Model
{
    public class Crow : Animal
    {
        public Crow(int noOfLegs, string color) : base(noOfLegs, color) { }

        public override string Cry()
        {
            return "Caw Caw";
        }

        public override string Fly()
        {
            return "Crow can fly up to 500 feet.";
        }

        public override void Walk()
        {
            Console.WriteLine($"Crow is walking with {NoOfLegs} legs.");
        }
    }
}
