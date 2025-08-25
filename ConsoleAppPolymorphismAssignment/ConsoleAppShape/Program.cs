using ConsoleAppShapes.Model;
namespace ConsoleAppShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Shape (Cube, Cyclinder, Sphere, Cone) : ");
            string shapeType = Console.ReadLine().ToLower();

            Shape shape = null;
            
            switch(shapeType)
            {
                case "cube":
                    Console.Write("Enter the side length of the cube: ");
                    double cubeSide = Convert.ToDouble(Console.ReadLine());
                    shape = new Cube(cubeSide);
                    break;

                case "cyclinder":
                    Console.Write("Enter the radius of the cylinder: ");
                    double cylinderRadius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the cylinder: ");
                    double cylinderHeight = Convert.ToDouble(Console.ReadLine());
                    shape = new Cyclinder(cylinderRadius, cylinderHeight);
                    break;

                case "sphere":
                    Console.Write("Enter the radius of the sphere: ");
                    double sphereRadius = Convert.ToDouble(Console.ReadLine());
                    shape = new Sphere(sphereRadius);
                    break;

                case "cone":
                    Console.Write("Enter the radius of the cone: ");
                    double coneRadius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the cone: ");
                    double coneHeight = Convert.ToDouble(Console.ReadLine());
                    shape = new Cone(coneRadius, coneHeight);
                    break;

                default:
                    Console.WriteLine("Invalid shape type entered.");
                    return;

            }

            Console.WriteLine($"The volume of the {shapeType} is: {shape.Volume()}");

        }   
    }
}
