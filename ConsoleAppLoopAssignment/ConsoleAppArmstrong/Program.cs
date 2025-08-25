using System.Runtime.Intrinsics.Arm;

namespace ConsoleAppArmstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int rem,sum = 0,temp;

            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }

            if (temp == sum)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not a Armstrong Number");
            Console.ReadKey();
        }
    }
}
