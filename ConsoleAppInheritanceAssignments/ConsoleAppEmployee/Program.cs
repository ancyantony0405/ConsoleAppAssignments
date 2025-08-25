using ConsoleAppEmployee.Model;

namespace ConsoleAppEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee number : ");
            int empNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee designation : ");
            string empDesignation = Console.ReadLine();

            Console.Write("Enter Employee basic salary : ");
            double empBasicSalary = Convert.ToDouble(Console.ReadLine());

            Executive executive = new Executive(empNo, empName, empDesignation, empBasicSalary);
            Console.WriteLine(executive.GetDetails());

        }
    }
}
