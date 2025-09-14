namespace ConsoleAppCollectionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> patients = new Queue<string>();

            // Get number of patient
            Console.Write("Enter number of patients to add: ");
            int count;
            if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            // Take patient names from user
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter name of patient {i}: ");
                string name = Console.ReadLine();
                patients.Enqueue(name);
            }

            // Enter the waiting list
            Console.WriteLine("Waiting List");
            foreach (var p in patients)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nCalling patients to doctor's room...");
            while (patients.Count > 0)
            {
                string nextPatient = patients.Dequeue();
                Console.WriteLine($"Next patient: {nextPatient}");
            }

            Console.WriteLine("\nAll patients have been attended.");
        }
    }
}
