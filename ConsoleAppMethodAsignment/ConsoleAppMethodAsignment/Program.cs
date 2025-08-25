namespace ConsoleAppMethodAsignment
{
    internal class Program
    {
        static int CountSpaces(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string:");
            string userInput = Console.ReadLine();

            int spaceCount = CountSpaces(userInput);

            Console.WriteLine("Number of spaces in the string: " + spaceCount);
        }
    }
}
