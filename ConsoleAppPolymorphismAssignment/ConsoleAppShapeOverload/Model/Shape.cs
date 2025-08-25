using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapeOverload.Model
{
    public class Shape
    {
        // Cube
        public double Volume(double side)
        {
            return side * side * side;
        }

        // Cylinder
        public double Volume(double radius, double height)
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }

        // Sphere
        public double Volume(double radius, bool isSphere)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        // Cone
        public double Volume(double radius, double height, bool isCone)
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }

        
    }
}
