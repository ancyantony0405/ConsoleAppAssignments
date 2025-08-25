namespace ConsoleAppMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your roll no: ");
            int rollNO = int.Parse(Console.ReadLine());

            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Enter your marks in subject1: ");
            int subject1 = int.Parse(Console.ReadLine());

            Console.Write("Enter your marks in subject2: ");
            int subject2 = int.Parse(Console.ReadLine());

            Console.Write("Enter your marks in subject3: ");
            int subject3 = int.Parse(Console.ReadLine());

            double Total = subject1 + subject2 + subject3;
            double percentage = Total / 3;

            Console.WriteLine($"Total Marks: {Total}");
            Console.WriteLine($"Percentage: {percentage:F2}%");

            if (percentage >= 60)
                Console.WriteLine("Division: First");
            else if (percentage >= 50)
                Console.WriteLine("Division: Second");
            else if (percentage >= 40)
                Console.WriteLine("Division: Third");
            else
                Console.WriteLine("Division: Fail");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}