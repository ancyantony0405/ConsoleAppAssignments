using ConsoleAppAutoParts.Model;

namespace ConsoleAppAutoParts
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List to hold all parts in the store 
            List<Parts> storeInventory = new List<Parts>();

            Console.Write("Enter number of parts to add: ");
            int partCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < partCount; i++)
            {
                Console.WriteLine($"Enter details for Part {i + 1}");

                Console.Write("Part Code: ");
                string code = Console.ReadLine();

                Console.Write("Part Name: ");
                string partName = Console.ReadLine();

                Console.Write("Category: ");
                string category = Console.ReadLine();

                Console.Write("Purchase Price: ");
                double purchasePrice = double.Parse(Console.ReadLine());

                Console.Write("Sale Price: ");
                double salePrice = double.Parse(Console.ReadLine());

                // Company details
                Console.WriteLine("Enter Manufacturing Company Details");
                Console.Write("Company Name: ");
                string compName = Console.ReadLine();

                Console.Write("Country: ");
                string country = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Phone: ");
                string phone = Console.ReadLine();

                Console.Write("Fax: ");
                string fax = Console.ReadLine();

                ManufacturingCompany company = new ManufacturingCompany(compName, country, address, phone, fax);

                Parts part = new Parts(code, partName, category, purchasePrice, salePrice, company);

                // Car compatibility
                Console.Write("\nHow many cars is this part compatible with? ");
                int carCount = int.Parse(Console.ReadLine());

                for (int j = 0; j < carCount; j++)
                {
                    Console.WriteLine($"\n--- Enter Car {j + 1} details ---");

                    Console.Write("Brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Model: ");
                    string model = Console.ReadLine();

                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());

                    Car car = new Car(brand, model, year);
                    part.AddCompatibleCar(car);
                }

                // Add part to store
                storeInventory.Add(part);
            }

            // Display all parts
            Console.WriteLine("\n=== Store Inventory ===");
            foreach (var part in storeInventory)
            {
                part.DisplayInfo();
            }
        }
    }
}