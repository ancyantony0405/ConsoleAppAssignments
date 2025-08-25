using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRectangle.Model
{
    public class Rectangle
    {
        public double xcoordinate { get; set; }
        public double ycoordinate { get; set; }

        // Constructor 
        public Rectangle(double x, double y)
        {
            xcoordinate = x;
            ycoordinate = y;
        }

        //Methods
        public double getArea()
        {
           return xcoordinate * ycoordinate;
        }
    }
}
