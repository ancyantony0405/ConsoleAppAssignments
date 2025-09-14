namespace ConsoleAppArithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int result = firstNumber / secondNumber;
                Console.WriteLine($"Result: {firstNumber} / {secondNumber} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
            }
        }
    }
}
