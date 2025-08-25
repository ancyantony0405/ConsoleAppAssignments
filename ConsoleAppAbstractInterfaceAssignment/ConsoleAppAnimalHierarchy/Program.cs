using ConsoleAppAnimalHierarchy.Model;

namespace ConsoleAppAnimalHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose Animal: Cat / Dog / Goat / Crow / Chicken");
            string choice = Console.ReadLine().ToLower();

            Animal animal = null;

            switch (choice.ToLower())
            {
                case "cat":
                    animal = new Cat(4, "White");
                    break;
                case "dog":
                    animal = new Dog(4, "Brown");
                    break;
                case "goat":
                    animal = new Goat(4, "Black");
                    break;
                case "crow":
                    animal = new Crow(2, "Black");
                    break;
                case "chicken":
                    animal = new Chicken(2, "Yellow");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine($"Animal: {choice}, Color: {animal.Color}");
            Console.WriteLine($"Cry: {animal.Cry()}");
            Console.WriteLine($"Fly: {animal.Fly()}");
            animal.Walk();
        }
    }
}
