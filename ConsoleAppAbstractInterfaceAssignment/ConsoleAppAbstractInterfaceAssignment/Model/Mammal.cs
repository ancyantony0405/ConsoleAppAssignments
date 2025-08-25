using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppMammal.Service;

namespace ConsoleAppMammal.Model
{
    public class Mammal : IMammals
    {
        private string name;

        
        public Mammal(string name)
        {
            this.name = name;
        }

        // Implement interface method
        public int GetBodyTemp(string type)
        {
            if (type.ToLower() == "human")
                return 37; // Normal body temp in Celsius
            else if (type.ToLower() == "dog")
                return 39;
            else if (type.ToLower() == "whale")
                return 36;
            else
                return 0; // Unknown
        }

        public void Display()
        {
            Console.WriteLine($"Mammal Name: {name}");
        }
    }
}

