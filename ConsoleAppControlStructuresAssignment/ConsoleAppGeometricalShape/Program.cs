namespace ConsoleAppGeometricalShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continueChoice = 'n';
            do
            {
                Console.WriteLine("Area of Geometric Shape");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Triangle");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter the choice :");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the side length of the square: ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        double areaSquare = side * side;
                        Console.WriteLine($"Area of Square: {areaSquare}");
                        break;

                    case 2:
                        Console.Write("Enter the length of the rectangle: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the width of the rectangle: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        double areaRectangle = length * width;
                        Console.WriteLine($"Area of Rectangle: {areaRectangle}");
                        break;

                    case 3:
                        Console.Write("Enter the radius of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        double areaCircle = 3.14 * radius * radius;
                        Console.WriteLine($"Area of Circle: {areaCircle}");
                        break;

                    case 4:
                        Console.Write("Enter the base of the triangle: ");
                        double baseTriangle = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the height of the triangle: ");
                        double heightTriangle = Convert.ToDouble(Console.ReadLine());
                        double areaTriangle = 0.5 * baseTriangle * heightTriangle;
                        Console.WriteLine($"Area of Triangle: {areaTriangle}");
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program.");
                        break;
                }
                //ask user if they want to continue
                Console.WriteLine("Do you want to perform another operation?\n\t(y to continue,n to exit)v:");
                continueChoice = Convert.ToChar(Console.ReadLine());
            } while (continueChoice == 'y');
            Console.WriteLine("Thank you for using the calculator!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

