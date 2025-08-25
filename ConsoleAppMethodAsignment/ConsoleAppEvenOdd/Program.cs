namespace ConsoleAppEvenOdd
{
    internal class Program
    {
        void printEven(int start, int end)
        {
            if (start > end)  // base case
                return;

            if (start % 2 == 0)
               Console.WriteLine(start);  // print even number

            printEven(start + 1, end);  // recursive call
        }

        void printOdd(int start, int end)
        {
            if (start > end)  // base case
                return;
            if (start % 2 != 0)
                Console.WriteLine(start);  // print odd number
            printOdd(start + 1, end);  // recursive call
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the start number : ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number : ");
            int endNumber = int.Parse(Console.ReadLine());

           Console.WriteLine("Even numbers between " + startNumber + " and " + endNumber + ":");
            Program program = new Program();
            program.printEven(startNumber, endNumber);
            Console.WriteLine("Odd numbers between " + startNumber + " and " + endNumber + ":");
            program.printOdd(startNumber, endNumber);
        }
    }
}
