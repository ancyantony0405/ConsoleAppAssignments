using ConsoleAppCellphoneAccountsSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellphoneAccountsSystem.Utility
{
    // Manages a collection of cellphone accounts
    public class CellphoneAccountSystem
    {
        private List<CellphoneAccount> accounts = new List<CellphoneAccount>();

        // Adds a new account to the system
        public void AddAccount(CellphoneAccount account)
        {
            accounts.Add(account);
        }

        // Displays all accounts in the system
        public void DisplayAll()
        {
            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc.Display());
            }
        }

        // Searches for an account by cellphone number
        public string SearchAccount(string number)
        {
            foreach (var acc in accounts)
            {
                if (acc.CellphoneNumber == number)
                    return acc.Display();
            }
            return "Account not found.";
        }
    }
}