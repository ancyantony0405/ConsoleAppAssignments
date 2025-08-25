namespace ConsoleAppLoopAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                int square = i * i;
                Console.Write(square + " ");
                sum = sum + square;
            }
            Console.WriteLine("\nSum = " + sum);
        }
    }
}
