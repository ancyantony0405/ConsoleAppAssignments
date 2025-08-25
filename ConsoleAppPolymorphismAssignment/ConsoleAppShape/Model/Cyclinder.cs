using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapes.Model
{
    public class Cyclinder : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public Cyclinder() 
        {
        }
        public Cyclinder(double radius,double height)
        {
            this.Radius = radius;
            this.Height = height;
        }
        
        public override double Volume()
        {
            // Volume of a cylinder = π * r^2 * h
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
}
