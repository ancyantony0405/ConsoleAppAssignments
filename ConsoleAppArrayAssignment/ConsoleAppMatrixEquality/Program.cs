namespace ConsoleAppMatrixEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbe of rows : ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns : ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rows, cols];
            int[,] matrixB = new int[rows, cols];

            // Input for Matrix A
            Console.WriteLine("\nEnter elements of Matrix A:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Input for Matrix B
            Console.WriteLine("\nEnter elements of Matrix B:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"B[{i},{j}] = ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool isEqual = true;
            // Check for equality
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrixA[i, j] != matrixB[i, j])
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (!isEqual) break;
            }
            // Display result
            if (isEqual)
            {
                Console.WriteLine("\nMatrices A and B are equal.");
            }
            else
            {
                Console.WriteLine("\nMatrices A and B are not equal.");
            }
        }
    }
}
