namespace ConsoleAppIndividualDigits
{
    internal class Program
    {
        static int SumOfDigits(int number)
        {
           if(number == 0) return 0;
            return number % 10 + SumOfDigits(number / 10);
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
