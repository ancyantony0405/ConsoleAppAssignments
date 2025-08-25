using ConsoleAppUniversity.Model;

namespace ConsoleAppUniversity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Details");
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Student student Id : ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Major(Graduate/Postgraduate) : ");
            string major = Console.ReadLine().ToLower();
            Student student = new Student(studentName, studentId, major);

            Console.WriteLine("Professor Details:");
            Console.Write("Enter Professor Name: ");
            string professorName = Console.ReadLine();
            Console.Write("Enter Employee Id : ");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Major: ");
            string professorMajor = Console.ReadLine();
            Professor professor = new Professor(professorName, employeeId, professorMajor);

            Console.WriteLine("Course Details:");
            Console.Write("Enter the titile of the course: ");
            string courseTitle = Console.ReadLine();
            Console.Write("Enter the course duration: ");
            int courseDuration = Convert.ToInt32(Console.ReadLine());
            Course course = new Course(courseTitle, courseDuration);

            Console.WriteLine("University Details:");
            Console.WriteLine(student.GetDetails());
            Console.WriteLine(professor.GetDetails());
            Console.WriteLine(course.GetDetails());

            Console.ReadKey();

        }
    }
}
