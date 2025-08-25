using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalHierarchy.Model
{
    public class Cat : Animal
    {
        public Cat(int noOfLegs, string color) : base(noOfLegs, color) { }

        public override string Cry()
        {
            return "Meow";
        }

        public override string Fly()
        {
            return "Cats cannot fly.";
        }

        public override void Walk()
        {
            Console.WriteLine($"Cat is walking with {NoOfLegs} legs.");
        }
    }
}
