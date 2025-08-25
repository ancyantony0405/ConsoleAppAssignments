using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapes.Model
{
    public class Cube : Shape
    {
        public double side { get; set; }
        public Cube()
        {
        }

        public Cube(double side)
        {
            this.side = side;
        }

        public override double Volume()
        {
            return side * side * side;
        }
    } 
}
