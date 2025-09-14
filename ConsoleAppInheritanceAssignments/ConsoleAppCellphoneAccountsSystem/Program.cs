using ConsoleAppCellphoneAccountsSystem.Model;
using ConsoleAppCellphoneAccountsSystem.Utility;

namespace ConsoleAppCellphoneAccountsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the cellphone account system
            CellphoneAccountSystem system = new CellphoneAccountSystem();
            int choice;

            do
            {
                Console.WriteLine("Cellphone Account System");
                Console.WriteLine("1. Add PayAsYouGo Account");
                Console.WriteLine("2. Add Contract Account");
                Console.WriteLine("3. Display All Accounts");
                Console.WriteLine("4. Search Account by Number");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    // Add PayAsYouGo Account
                    case 1:
                        Console.Write("Enter Cellphone Number: ");
                        string pNum = Console.ReadLine();
                        Console.Write("Enter Total Call Time (mins): ");
                        int pTime = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Total Cost: ");
                        double pCost = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Account Type (C=Callmore, P=Peak, A=Any): ");
                        string type = Console.ReadLine();

                        system.AddAccount(new PayAsYouGo(pNum, pTime, pCost, type));
                        Console.WriteLine("PayAsYouGo account added successfully!");
                        break;

                    // Add Contract Account
                    case 2:
                        Console.Write("Enter Cellphone Number: ");
                        string cNum = Console.ReadLine();
                        Console.Write("Enter Total Call Time (mins): ");
                        int cTime = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Total Cost: ");
                        double cCost = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Holder Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter Contract Length (months): ");
                        int length = Convert.ToInt32(Console.ReadLine());

                        system.AddAccount(new Contract(cNum, cTime, cCost, name, address, length));
                        Console.WriteLine("Contract account added successfully!");
                        break;

                    // Display All Accounts
                    case 3:
                        Console.WriteLine("\nAll Accounts:");
                        system.DisplayAll();
                        break;

                    // Search Account by Number
                    case 4:
                        Console.Write("Enter Cellphone Number to Search: ");
                        string searchNum = Console.ReadLine();
                        Console.WriteLine(system.SearchAccount(searchNum));
                        break;

                    // Exit
                    case 5:
                        Console.WriteLine("Exiting!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 5);
        }
    }
}