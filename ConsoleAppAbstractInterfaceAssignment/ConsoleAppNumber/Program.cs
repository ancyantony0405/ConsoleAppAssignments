using ConsoleAppNumber.Model;
using ConsoleAppNumber.Service;

namespace ConsoleAppNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number obj = new Number();

            Console.WriteLine("Choose Interface (1/2) : ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                IFirst firstRef = obj;
                firstRef.Display();                        // Calls IFirst.Display
                Console.WriteLine("Value: " + firstRef.GetValue());
            }
            else if (choice == "2")
            {
                ISecond secondRef = obj;
                secondRef.Display();                       // Calls ISecond.Display
                secondRef.Demo();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
