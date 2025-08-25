namespace ConsoleAppSwapNumbers
{
    internal class Program
    {
        static (int, int) SwapNumbers(int firstNumber, int secondNumber)
        {
            // Swapping logic
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            return (firstNumber , secondNumber);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number :");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping:");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);

            (firstNumber, secondNumber) = SwapNumbers(firstNumber, secondNumber);

            Console.WriteLine("After swapping:");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}
