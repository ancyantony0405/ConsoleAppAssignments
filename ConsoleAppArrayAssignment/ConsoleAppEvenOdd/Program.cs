namespace ConsoleAppEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            int[] evenArr = new int[evenCount];
            int[] oddArr = new int[oddCount];

            int e = 0, o = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                    evenArr[e++] = arr[i];
                else
                    oddArr[o++] = arr[i];
            }
            Console.WriteLine("Even elements:");
            foreach (var item in evenArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Odd elements:");
            foreach (var item in oddArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
