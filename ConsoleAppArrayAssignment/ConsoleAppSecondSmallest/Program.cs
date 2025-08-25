namespace ConsoleAppSecondSmallest
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

            if (n < 2)
            {
                Console.WriteLine("Not enough elements.");
                return;
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in arr)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num > smallest && num < secondSmallest)
                {
                    secondSmallest = num;
                }
            }

            if (secondSmallest == int.MaxValue)
                Console.WriteLine("No second smallest element (all numbers same).");
            else
                Console.WriteLine("Second smallest element = " + secondSmallest);
        }
    }

}
    
