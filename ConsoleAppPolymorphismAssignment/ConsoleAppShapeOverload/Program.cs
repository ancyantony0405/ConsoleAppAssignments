using ConsoleAppShapeOverload.Model;
namespace ConsoleAppShapeOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Shape (Cube, Cyclinder, Sphere, Cone) : ");
            string shapeType = Console.ReadLine().ToLower();

            Shape shape = new Shape();
           

            switch(shapeType)
            {
                case "cube":
                    Console.Write("Enter the side length of the cube: ");
                    double cubeSide = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"The volume of the cube is: {shape.Volume(cubeSide)}");
                    break;
                case "cyclinder":
                    Console.Write("Enter the radius of the cylinder: ");
                    double cylinderRadius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the cylinder: ");
                    double cylinderHeight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"The volume of the cylinder is: {shape.Volume(cylinderRadius, cylinderHeight)}");
                    break;
                case "sphere":
                    Console.Write("Enter the radius of the sphere: ");
                    double sphereRadius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"The volume of the sphere is: {shape.Volume(sphereRadius, true)}");
                    break;
                case "cone":
                    Console.Write("Enter the radius of the cone: ");
                    double coneRadius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the cone: ");
                    double coneHeight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"The volume of the cone is: {shape.Volume(coneRadius, coneHeight, true)}");
                    break;
                default:
                    Console.WriteLine("Invalid shape type entered.");
                    return;
            }
        }
    }
}
