namespace ConsoleAppDivisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0, sum = 0;

            Console.WriteLine("Numbers between 100 and 200 divisible by 9:");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                    sum += i;
                }
            }

            Console.WriteLine("\n\nTotal numbers: " + count);
            Console.WriteLine("Sum of numbers: " + sum);

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
