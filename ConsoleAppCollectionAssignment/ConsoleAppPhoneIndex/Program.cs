using System.Collections;

namespace ConsoleAppPhoneIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedList (key = Name, value = Phone Number)
            SortedList phoneIndex = new SortedList();

            Console.WriteLine("Enter number of contacts:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                string phone = Console.ReadLine();

                // Add to SortedList
                if (!phoneIndex.ContainsKey(name))
                    phoneIndex.Add(name, phone);
                else
                    Console.WriteLine("Contact already exists");
            }

            // Display all contacts (SortedList will automatically sort by Name)
            Console.WriteLine("Contacts in Phone Index:");
            foreach (DictionaryEntry entry in phoneIndex)
            {
                Console.WriteLine($"{entry.Key} → {entry.Value}");
            }

            // Search for a contact
            Console.Write("\nEnter a name to search: ");
            string searchName = Console.ReadLine();

            if (phoneIndex.ContainsKey(searchName))
                Console.WriteLine($"{searchName}'s Number: {phoneIndex[searchName]}");
            else
                Console.WriteLine("Contact not found");

        }
    }
}
