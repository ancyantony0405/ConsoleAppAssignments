using ConsoleAppMyAnimals.Model;
using ConsoleAppMyAnimals.Service;
namespace ConsoleAppMyAnimals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the mammal: ");
            string name = Console.ReadLine();

            Console.Write("Enter its body temperature (°C): ");
            int temp = Convert.ToInt32(Console.ReadLine());

            // Create object with user input
            MyAnimals animal = new MyAnimals(temp);

            // Call method
            animal.GetBodyTemp(name);
        }
    }
}
