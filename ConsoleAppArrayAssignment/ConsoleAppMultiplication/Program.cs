namespace ConsoleAppMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] A = new int[rows, cols];
            int[,] B = new int[rows, cols];
            int[,] product = new int[rows, cols];

            // Input for Matrix A
            Console.WriteLine("\nEnter elements of Matrix A:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Input for Matrix B
            Console.WriteLine("\nEnter elements of Matrix B:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"B[{i},{j}] = ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Multiplying Matrices
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    product[i, j] = A[i, j] * B[i, j];
                }
            }

            // Display Result
            Console.WriteLine("\nResultant Matrix (A * B):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(product[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}