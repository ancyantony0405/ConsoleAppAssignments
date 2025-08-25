namespace ConsoleAppAdmissionEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the mark in maths :");
            double mathsMark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the mark in physics :");
            double physicsMark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the mark in chemistry :");
            double chemistryMark = Convert.ToDouble(Console.ReadLine());

            double TotalMark = mathsMark + physicsMark + chemistryMark;
            double TotalMathPhysics = mathsMark + physicsMark;

            if ((mathsMark >= 65 && physicsMark >= 55 && chemistryMark >= 50 && TotalMark >= 180)
                || (TotalMathPhysics >= 140))
                Console.WriteLine("You are eligible for admission");
            else
                Console.WriteLine("You are not eligible for admission");


        }
    }
}
