using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalHierarchy.Model
{
    public class Dog : Animal
    {
        public Dog(int noOfLegs, string color) : base(noOfLegs, color) { }

        public override string Cry()
        {
            return "Bow Wow";
        }

        public override string Fly()
        {
            return "Dogs cannot fly.";
        }

        public override void Walk()
        {
            Console.WriteLine($"Dog is walking with {NoOfLegs} legs.");
        }
    }
}
