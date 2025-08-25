namespace ConsoleAppSimpleCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = 0, SecondNumber = 0;
            char continueChoice = 'n';
            do
            {
                Console.Write("Enter first number: ");
                FirstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                SecondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                //Get the choice
                Console.Write("Enter your choice(1-4) :");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Sum is :" + (FirstNumber + SecondNumber));
                        break;
                    case 2:
                        Console.WriteLine("Difference is :" + (FirstNumber - SecondNumber));
                        break;
                    case 3:
                        Console.WriteLine("Product is :" + (FirstNumber * SecondNumber));
                        break;
                    case 4:
                        Console.WriteLine("Quotient is :" + (FirstNumber / SecondNumber));
                        break;
                    default:
                        Console.WriteLine("Invalide choice..");
                        break;

                }
                Console.WriteLine("Do you want to perform another operation?\n\t(y to continue,n to exit)v:");
                continueChoice = Convert.ToChar(Console.ReadLine());
            } while (continueChoice == 'y');
            Console.WriteLine("Thank you for using the calculator!");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

