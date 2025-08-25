namespace ConsoleAppPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("Number must be greater than 1");
                return;
            }
            else 
                for(int i =2;i < number;i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("Number is not prime");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Number is prime");
                        return;
                    }
                }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
