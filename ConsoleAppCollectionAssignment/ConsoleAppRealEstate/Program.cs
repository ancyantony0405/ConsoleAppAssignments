using ConsoleAppRealEstate.Model;

namespace ConsoleAppRealEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Company details
            Console.Write("Enter Company Name: ");
            string companyName = Console.ReadLine();

            Console.Write("Enter Owner Name: ");
            string owner = Console.ReadLine();

            Console.Write("Enter Tax ID: ");
            string taxId = Console.ReadLine();

            Company company = new Company(companyName, owner, taxId);

            // Employees
            Console.Write("\nEnter number of employees: ");
            int empCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < empCount; i++)
            {
                Console.WriteLine($"\n--- Employee {i + 1} ---");
                Console.Write("Name: ");
                string empName = Console.ReadLine();

                Console.Write("Position: ");
                string position = Console.ReadLine();

                Console.Write("Experience (years): ");
                int experience = int.Parse(Console.ReadLine());

                company.AddEmployee(new Employee(empName, position, experience));
            }

            // Estates
            Console.Write("\nEnter number of estates: ");
            int estateCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < estateCount; i++)
            {
                Console.WriteLine($"\n--- Estate {i + 1} ---");
                Console.WriteLine("Choose type: 1. Apartment  2. House  3. Shop  4. UndevelopedArea");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Area (sqm): ");
                double area = double.Parse(Console.ReadLine());

                Console.Write("Price per sqm: ");
                double pricePerSqm = double.Parse(Console.ReadLine());

                Console.Write("Location: ");
                string location = Console.ReadLine();

                Estate estate = null;

                switch (choice)
                {
                    case 1: // Apartment
                        Console.Write("Floor: ");
                        int floor = int.Parse(Console.ReadLine());

                        Console.Write("Has Elevator (true/false): ");
                        bool hasElevator = bool.Parse(Console.ReadLine());

                        Console.Write("Is Furnished (true/false): ");
                        bool isFurnishedA = bool.Parse(Console.ReadLine());

                        estate = new Apartment(area, pricePerSqm, location, floor, hasElevator, isFurnishedA);
                        break;

                    case 2: // House
                        Console.Write("Developed Area (sqm): ");
                        double devArea = double.Parse(Console.ReadLine());

                        Console.Write("Yard Area (sqm): ");
                        double yardArea = double.Parse(Console.ReadLine());

                        Console.Write("Number of Floors: ");
                        int floors = int.Parse(Console.ReadLine());

                        Console.Write("Is Furnished (true/false): ");
                        bool isFurnishedH = bool.Parse(Console.ReadLine());

                        estate = new House(area, pricePerSqm, location, devArea, yardArea, floors, isFurnishedH);
                        break;

                    case 3: // Shop
                        estate = new Shop(area, pricePerSqm, location);
                        break;

                    case 4: // UndevelopedArea
                        estate = new UndevelopedArea(area, pricePerSqm, location);
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        i--; // redo this iteration
                        continue;
                }

                company.AddEstate(estate);
            }

            // Display everything
            Console.WriteLine("\n=== Company Profile ===");
            company.DisplayInfo();
        }
    }
}