namespace ConsoleAppSumOfElements
{
    internal class Program
    {
        static int SumOfElements(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array :");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine("Enter the elements of the array :");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = SumOfElements(numbers);
            Console.WriteLine("The sum of the elements in the array is: " + sum);
        }
    }
}
