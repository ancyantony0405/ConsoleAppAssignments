namespace ConsoleAppArrayAssignment
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

            // Sort the array
            Array.Sort(arr);

            int duplicateCount = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    duplicateCount++;

                    // skip all same elements to avoid counting multiple times
                    while (i < n - 1 && arr[i] == arr[i + 1])
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements = " + duplicateCount);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
