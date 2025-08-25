using ConsoleAppAnimal.Model;
using ConsoleAppAnimals.Model;

namespace ConsoleAppAnimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Animal Type (Cat / Dog): ");
            string choice = Console.ReadLine().ToLower();

            if (choice.Equals("Cat", StringComparison.OrdinalIgnoreCase))
            {
                Animals cat = new Cat();
                cat.SaySomething();
            }
            else if (choice.Equals("Dog", StringComparison.OrdinalIgnoreCase))
            {
                Animals dog = new Dog();
                dog.SaySomething();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
