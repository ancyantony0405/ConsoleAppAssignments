namespace ConsoleAppIndividualDigits
{
    internal class Program
    {
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10; // Get the last digit
                sum += digit; // Add the last digit to the sum
                number /= 10; // Remove the last digit
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number :");
            int number = int.Parse(Console.ReadLine());

            int sum = SumOfDigits(number);

            Console.WriteLine("The sum of the individual digits in the number is: " + sum);
        }
    }
}
