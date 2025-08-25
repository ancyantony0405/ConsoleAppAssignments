namespace ConsoleAppStrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Strong numbers between {start} and {end}:");

            // Loop through the range from start to end
            for (int num = start; num <= end; num++)
            {
                int temp = num;
                int sum = 0;

                // calculate sum of factorial of digits
                for (int n = num; n > 0; n /= 10)
                {
                    int digit = n % 10;
                    int fact = 1;

                    // factorial of digit
                    for (int i = 1; i <= digit; i++)
                    {
                        fact *= i;
                    }

                    sum += fact;
                }

                if (sum == temp)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
