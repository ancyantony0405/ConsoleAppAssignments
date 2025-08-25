using ConsoleAppMammal.Model;
using ConsoleAppMammal.Service;

namespace ConsoleAppAbstractInterfaceAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of a mammal (Human, Dog, Whale): ");
            string input = Console.ReadLine().ToLower();

            IMammals mammal = new Mammal(input);
            int temp = mammal.GetBodyTemp(input);

            if (temp != -1)
                Console.WriteLine($"{input} Body Temp: {temp} °C");
            else
                Console.WriteLine("Sorry, body temperature for this mammal is not available.");
        }
    }
}
