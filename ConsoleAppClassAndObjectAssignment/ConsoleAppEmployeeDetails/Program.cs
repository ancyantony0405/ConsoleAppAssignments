using ConsoleAppEmployeeDetails.Model;
namespace ConsoleAppEmployeeDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Employee details");
            emp.name = "Anx"; // Set employee name
            emp.baseSalary = 50000; // Set base salary
            emp.yearsOfService = 5; // Set years of service
            emp.CalculateBonus(); // Calculate bonus
            emp.TotalSalary(); // Calculate total salary
            Console.WriteLine(emp); // Print employee details
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
