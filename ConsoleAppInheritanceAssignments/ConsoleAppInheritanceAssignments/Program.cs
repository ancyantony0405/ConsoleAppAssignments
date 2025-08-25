using ConsoleAppPerson.Model;

namespace ConsoleAppInheritanceAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the type of person (Student/employee): ");
            string personType = Console.ReadLine();

            Person per = null;

           if (personType.Equals("Student", StringComparison.OrdinalIgnoreCase))
            {
                Student student = new Student();
                student.Get_data();
                student.Compute_Grade();
                student.Display_data();
            }

           else if (personType.Equals("Employee", StringComparison.OrdinalIgnoreCase))
            {
                Employee emp = new Employee();
                emp.Get_data();
                emp.ComputeSalary();
                emp.Display_data();
            }
            else
            {
                Console.WriteLine("Invalid person type entered.");
            }
        }
    }
}
