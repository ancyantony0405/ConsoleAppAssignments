using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellphoneAccountsSystem.Model
{
    public class Contract : CellphoneAccount
    {
        public string HolderName { get; set; }
        public string Address { get; set; }
        public int ContractLength { get; set; } // in months

        public Contract(string cellphoneNumber, int totalCallTime, double totalCost,
                        string holderName, string address, int contractLength)
            : base(cellphoneNumber, totalCallTime, totalCost)
        {
            HolderName = holderName;
            Address = address;
            ContractLength = contractLength;
        }

        public override string Display()
        {
            return base.Display() +
                   $", Name: {HolderName}, Address: {Address}, Contract Length: {ContractLength} months";
        }
    }
}
