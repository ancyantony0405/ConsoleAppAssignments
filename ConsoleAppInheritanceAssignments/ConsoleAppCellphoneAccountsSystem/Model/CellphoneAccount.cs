using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellphoneAccountsSystem.Model
{
    // Base class
    public class CellphoneAccount
    {
        // Fields
        public string CellphoneNumber { get; set; }
        public int TotalCallTime { get; set; }
        public double TotalCost { get; set; }

        // Constructor
        public CellphoneAccount(string cellphoneNumber, int totalCallTime, double totalCost)
        {
            CellphoneNumber = cellphoneNumber;
            TotalCallTime = totalCallTime;
            TotalCost = totalCost;
        }

        // Method to display account information
        public virtual string Display()
        {
            return $"Number: {CellphoneNumber}, Calls: {TotalCallTime}, Cost: {TotalCost}";
        }
    }
}