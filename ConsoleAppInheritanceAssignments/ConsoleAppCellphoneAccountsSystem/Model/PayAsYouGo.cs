using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellphoneAccountsSystem.Model
{
    // Derived class
    public class PayAsYouGo : CellphoneAccount
    {
        // Fields
        public string AccountType { get; set; }  // C, P, A

        // Constructor
        public PayAsYouGo(string cellphoneNumber, int totalCallTime, double totalCost, string accountType)
            : base(cellphoneNumber, totalCallTime, totalCost)
        {
            AccountType = accountType;
        }

        // Override method to display account information
        public override string Display()
        {
            return base.Display() + $", Type: {AccountType}";
        }
    }
}
