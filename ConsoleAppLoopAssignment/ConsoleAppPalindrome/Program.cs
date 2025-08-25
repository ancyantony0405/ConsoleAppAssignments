namespace ConsoleAppPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, temp;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;     
                num = num / 10;     
                sum = sum * 10 + rem;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not a palindrome");
            }
                Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
