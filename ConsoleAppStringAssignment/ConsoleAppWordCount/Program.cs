namespace ConsoleAppWordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string inputString = Console.ReadLine();

            int wordCount = 0;

            foreach(char c in inputString)
            {
                if (char.IsLetter(c))
                    wordCount++;
            }
            Console.WriteLine($"The number of words in the string is: {wordCount}");
        }
    }
}
