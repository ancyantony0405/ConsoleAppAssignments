namespace ConsoleAppLoginProgram
{
    internal class Program
    {
        string correctUsername = "admin";
        string correctPassword = "1234";

        public void Run()
        {
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful!");
                    return;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Invalid credentials. Attempts left: {3 - attempts}");
                }
            }

            Console.WriteLine("Too many attempts. Access denied.");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
    }
}
