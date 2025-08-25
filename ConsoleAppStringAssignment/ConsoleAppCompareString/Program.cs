namespace ConsoleAppCompareString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first string : ");
            string firstString = Console.ReadLine();

            Console.Write("Enter the second string : ");
            string secondString = Console.ReadLine();

            if (firstString == secondString)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }
        }
    }
}
