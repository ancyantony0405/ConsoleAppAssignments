namespace ConsoleAppSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the starting string : ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of substring : ");
            int length = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = start; i < start + length && i < inputString.Length; i++)
            {
                result += inputString[i];
            }

            Console.WriteLine($"Extracted Substring: {result}");


            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
