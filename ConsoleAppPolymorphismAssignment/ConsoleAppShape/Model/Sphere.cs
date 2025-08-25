using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapes.Model
{
    public class Sphere : Shape
    {
        public double radius { get; set; }
        public Sphere()
        {
        }
        public Sphere(double radius)
        {
            this.radius = radius;
        }
        public override double Volume()
        {
            // Volume of a sphere = (4/3) * π * r^3
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
}
