namespace ConsoleAppPrimeNumber
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1) return false; 
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false; 
            }
            return true; 
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it is prime: ");
            int number = int.Parse(Console.ReadLine());

            bool result = IsPrime(number);
            if (result)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " is not prime number");
            }

        }
    }
}
