namespace ConsoleAppFibonacci
{
    internal class Program
    {
        static void DisplayFibonacci(int number)
        {
            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                first = second;
                second = next;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int number = Convert.ToInt32(Console.ReadLine());

            DisplayFibonacci(number);

        }
    }
}
