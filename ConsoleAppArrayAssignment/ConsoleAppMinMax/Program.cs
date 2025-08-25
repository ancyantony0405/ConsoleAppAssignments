namespace ConsoleAppMinMax
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
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Maximum element = " + max);
            Console.WriteLine("Minimum element = " + min);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
