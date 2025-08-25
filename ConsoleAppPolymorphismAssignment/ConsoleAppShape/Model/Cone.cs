using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapes.Model
{
    public class Cone : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public Cone()
        {
        }
        public Cone(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }
        public override double Volume()
        {
            // Volume of a cone = (1/3) * π * r^2 * h
            return (1.0 / 3.0) * Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
    
}
