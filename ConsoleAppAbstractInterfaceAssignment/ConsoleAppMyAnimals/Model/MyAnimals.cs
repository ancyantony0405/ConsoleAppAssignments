using ConsoleAppMyAnimals.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyAnimals.Model
{
    public abstract class Animals
    {
        
    }

    // MyAnimals class
    public class MyAnimals : Animals, IMammals
    {
        // Property
        public int BodyTemp { get; set; }

        // Constructor
        public MyAnimals(int temp)
        {
            BodyTemp = temp;
        }

        // Implement interface
        public int GetBodyTemp(string name)
        {
            Console.WriteLine($"{name}'s body temperature is {BodyTemp}°C.");
            return BodyTemp;
        }
    }
}
