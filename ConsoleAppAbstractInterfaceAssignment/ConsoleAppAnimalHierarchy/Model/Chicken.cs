using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalHierarchy.Model
{
    public class Chicken : Animal
    {
        public Chicken(int noOfLegs, string color) : base(noOfLegs, color) { }

        public override string Cry()
        {
            return "Cluck Cluck";
        }

        public override string Fly()
        {
            return "Chicken can fly only a few feet above the ground.";
        }

        public override void Walk()
        {
            Console.WriteLine($"Chicken is walking with {NoOfLegs} legs.");
        }
    }
}
