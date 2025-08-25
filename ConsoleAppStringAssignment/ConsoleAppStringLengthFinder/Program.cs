namespace ConsoleAppStringLengthFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string intputString = Console.ReadLine();

            int length = 0;

            foreach(char c in intputString)
            {
                length++;
            }
            Console.WriteLine($"The length of the string is: {length}");
        }
    }
}
