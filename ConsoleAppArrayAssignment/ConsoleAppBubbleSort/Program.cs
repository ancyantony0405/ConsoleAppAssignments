namespace ConsoleAppBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of arrey : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Bubble Sort Algorithm
            for (int i=0;i < n-1;i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array : ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
