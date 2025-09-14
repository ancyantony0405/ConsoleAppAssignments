namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1; // Fill array with values 1 to 10
            }

            Console.Write("Enter the index to access element: ");
            int index = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Element at index " + index + " = " + arr[index]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Index out of range. " + ex.Message);
            }
        }
    }
}
