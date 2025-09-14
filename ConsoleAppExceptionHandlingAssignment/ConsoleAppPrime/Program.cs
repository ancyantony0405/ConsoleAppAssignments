namespace ConsoleAppPrime
{
    public class Prime
    {
        // Check if number is prime
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // Generate random number and throw exception if it's prime
        static int GetRandomNumber()
        {
            Random rand = new Random();
            int number = rand.Next(1, 100); // random 1–99

            if (IsPrime(number))
                throw new Exception($"Generated number {number} is PRIME!");

            return number;
        }
        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    int num = GetRandomNumber();
                    Console.WriteLine("Generated number: " + num);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);
                }
            }
        }
    }
}
