using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapes.Model
{
    public class Shape
    {
        public double side { get; set; }

        public virtual double Volume()
        {
            double side = 10; // Default value for side
            return side * side * side;
        }
    }

}