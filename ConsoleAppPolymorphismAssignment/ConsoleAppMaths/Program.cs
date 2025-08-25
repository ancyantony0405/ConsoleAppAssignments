using ConsoleAppMaths.Model;

namespace ConsoleAppMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the operation (add, subtract, multiply, divide): ");
            string operation = Console.ReadLine().ToLower();

            Maths math = new Maths();

            switch (operation)
            {
                case "add":
                    math.AcceptNumbers();
                    Console.WriteLine($"The result of addition is: {math.Add()}");
                    break;
                case "subtract":
                    math.AcceptNumbers();
                    Console.WriteLine($"The result of subtraction is: {math.Subtract()}");
                    break;
                case "multiply":
                    math.AcceptNumbers();
                    Console.WriteLine($"The result of multiplication is: {math.Multiply()}");
                    break;
                case "divide":
                    math.AcceptNumbers();
                    Console.WriteLine($"The result of division is: {math.Divide()}");
                    break;
                default:
                    Console.WriteLine("Invalid operation entered.");
                    break;
            }
        }
    }
}
