using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalHierarchy.Model
{
    public class Goat : Animal
    {
        public Goat(int noOfLegs, string color) : base(noOfLegs, color) { }

        public override string Cry()
        {
            return "Baaa";
        }

        public override string Fly()
        {
            return "Goats cannot fly.";
        }

        public override void Walk()
        {
            Console.WriteLine($"Goat is walking with {NoOfLegs} legs.");
        }
    }
}
