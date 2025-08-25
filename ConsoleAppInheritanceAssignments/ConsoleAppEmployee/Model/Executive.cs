using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployee.Model
{
    public class Executive : Employee
    {
        public Executive(int employeeNo, string name, string designation, double basepay)
            : base(employeeNo, name, designation, basepay)
        {
            if (basepay <= 10000)
            {
                Console.WriteLine("Base pay for Executive should be greater than 10000.");
            }
        }

        public override string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Executive Details:");
            sb.AppendLine(base.GetDetails());
            return sb.ToString();
        }
    }
}
