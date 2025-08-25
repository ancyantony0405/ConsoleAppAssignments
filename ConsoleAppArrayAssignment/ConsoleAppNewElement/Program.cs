namespace ConsoleAppNewElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n + 1]; // extra space for new element

            Console.WriteLine("Enter elements in ascending order:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter new value to insert: ");
            int value = int.Parse(Console.ReadLine());

            int pos = n; // default position is at the end

            // Find correct position to insert
            for (int i = 0; i < n; i++)
            {
                if (value < arr[i])
                {
                    pos = i;
                    break;
                }
            }

            // Shift elements to right
            for (int i = n; i > pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            // Insert new value
            arr[pos] = value;

            Console.WriteLine("\nArray after insertion:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
