namespace ConsoleAppAlphabetPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for the alphabet pattern: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                // Print increasing sequence (A to current row letter)
                for (int j = 0; j < i; j++)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                // Print decreasing sequence (row-1 back to A)
                for (int j = i - 2; j >= 0; j--)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
