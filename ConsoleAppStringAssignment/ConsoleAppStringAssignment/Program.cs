namespace ConsoleAppStringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            foreach(char c in inputString)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount += c - '0';
                }
                else if (char.IsDigit(c))
                {
                    digitCount += c - '0';
                }
                else if (!char.IsWhiteSpace(c))
                {
                    specialCharCount += c - '0';
                }
            }
            Console.WriteLine($"Alphabets: {alphabetCount}");
            Console.WriteLine($"Digits: {digitCount}");
            Console.WriteLine($"Special Characters: {specialCharCount}");

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }

}
