using ConsoleAppVehicle.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVehicle.Utility
{
    public class VehicleRegistration
    {
        // Collection: LicenseNumber → Vehicle
        private Hashtable vehicles = new Hashtable();

        // Add a new vehicle
        public void RegisterVehicle(string licenseNumber, Vehicle vehicle)
        {
            if (!vehicles.ContainsKey(licenseNumber))
            {
                vehicles.Add(licenseNumber, vehicle);
                Console.WriteLine($"Vehicle with License {licenseNumber} registered");
            }
            else
            {
                Console.WriteLine($"License {licenseNumber} already exists!");
            }
        }

        // Retrieve a vehicle by license number
        public Vehicle GetVehicle(string licenseNumber)
        {
            if (vehicles.ContainsKey(licenseNumber))
                return (Vehicle)vehicles[licenseNumber];
            else
                return null;
        }
    }
}
