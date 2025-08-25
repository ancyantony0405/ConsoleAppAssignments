namespace ConsoleAppBinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            int binary = int.Parse(Console.ReadLine());

            int decimalNum = 0, baseVal = 1;

            // using for loop only
            for (; binary > 0; binary = binary / 10)
            {
                int lastDigit = binary % 10;
                decimalNum += lastDigit * baseVal;
                baseVal *= 2;
            }

            Console.WriteLine("Decimal number: " + decimalNum);

            Console.WriteLine("Pressany key to continue...");
            Console.ReadKey();
        }
    }
}
