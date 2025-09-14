using ConsoleAppVehicle.Model;
using ConsoleAppVehicle.Utility;

namespace ConsoleAppVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleRegistration registry = new VehicleRegistration();

            Console.Write("Enter number of vehicles to register: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Details for Vehicle {i + 1}");
                Console.Write("Enter License Number: ");
                string license = Console.ReadLine();

                Console.Write("Enter Make (Brand): ");
                string make = Console.ReadLine();

                Console.Write("Enter Model: ");
                string model = Console.ReadLine();

                Console.Write("Enter Year: ");
                int year = int.Parse(Console.ReadLine());

                Vehicle v = new Vehicle(make, model, year);
                registry.RegisterVehicle(license, v);
            }

            Console.WriteLine("Enter License Number to Search: ");
            string searchLicense = Console.ReadLine();

            Vehicle found = registry.GetVehicle(searchLicense);

            if (found != null)
                Console.WriteLine($"Vehicle Found: {found}");
            else
                Console.WriteLine("Vehicle not found.");
        }
    }
}