using System.Runtime.Serialization.Formatters;

namespace ConsoleAppReverseStringCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string inputString = Console.ReadLine();

            Console.Write("Reversed string: ");

            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputString[i]);
            }
        }
    }
}
