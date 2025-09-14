namespace ConsoleAppExceptionHandlingAssignment
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            if (age < 18 || age > 60)
            {
                throw new ArgumentOutOfRangeException("Age must be between 18 and 60");
            }
            Name = name;
            Age = age;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the name :");
                string name = Console.ReadLine();

                Console.Write("Enter the age :");
                int age = Convert.ToInt32(Console.ReadLine());

                Employee employee = new Employee(name, age);
                Console.WriteLine($"Employee Name: {employee.Name}, Age: {employee.Age}");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
