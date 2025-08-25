namespace ConsoleAppTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
