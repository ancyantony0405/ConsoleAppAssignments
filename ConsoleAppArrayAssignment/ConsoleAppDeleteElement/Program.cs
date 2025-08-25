namespace ConsoleAppDeleteElement
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

            Console.Write("Enter position to delete (1 to {0}): ", n);
            int pos = int.Parse(Console.ReadLine());

            if (pos < 1 || pos > n)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                // Shift elements left
                for (int i = pos - 1; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                n--; // reduce size

                Console.WriteLine("\nArray after deletion:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
