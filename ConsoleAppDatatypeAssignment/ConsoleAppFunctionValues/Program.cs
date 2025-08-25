namespace ConsoleAppFunctionValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y\t x = y^2 + 2y + 1");

            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"{y}\t {x}");
            }
        }
    }
}
