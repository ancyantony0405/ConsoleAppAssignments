namespace ConsoleAppRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of rectangle");
            Console.Write("Enter the xcoordinate of the rectangle: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the ycoordinate of the rectangle: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Create an instance of Rectangle
            Model.Rectangle rectangle = new Model.Rectangle(x, y);
            // Calculate the area
            double area = rectangle.getArea();
            // Display the area
            Console.WriteLine($"The area of the rectangle with coordinates ({x}, {y}) is: {area}");
        }
    }
}
