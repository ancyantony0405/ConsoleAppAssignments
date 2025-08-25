namespace ConsoleAppRangeOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the starting number : ");
            int startNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the ending number : ");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {startNumber} and {endNumber}:");

            for (int number = startNumber; number <= endNumber; number++)
            {
                if (number <= 1)
                    continue;

                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.Write(number + " ");
            }
        }

    }
}

