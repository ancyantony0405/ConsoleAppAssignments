namespace ConsoleAppControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.Write("Enter your age:");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("You are eligible to vote.");
            else
                Console.WriteLine("You are not eligible to vote.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
