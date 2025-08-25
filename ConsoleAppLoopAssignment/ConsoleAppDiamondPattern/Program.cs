namespace ConsoleAppDiamondPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // Print leading spaces
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                // Print leading spaces
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
