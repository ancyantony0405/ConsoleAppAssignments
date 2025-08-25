namespace ConsoleAppFibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms for the Fibonacci series: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 0, secondNumber = 1, next;


            for (int i = 1; i <= terms; i++)
            {
                Console.WriteLine(firstNumber + " ");
                next = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = next;
            }

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
