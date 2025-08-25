namespace ConsoleAppPatternA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display the pattern like 'A' with an asterisk:");

            int height = 7;   // height of A
            int width = 5;    // width of A
            int mid = height / 2; // row where the horizontal bar is

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if ((col == 0 || col == width - 1) && row != 0) // left & right side (skip top corners)
                        Console.Write("*");
                    else if (row == 0 && col > 0 && col < width - 1) // top line
                        Console.Write("*");
                    else if (row == mid) // middle line
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
