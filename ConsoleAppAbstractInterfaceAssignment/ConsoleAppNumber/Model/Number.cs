using ConsoleAppNumber.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNumber.Model
{
    public class Number : IFirst, ISecond
    {
        void IFirst.Display()
        {
            Console.WriteLine("IFirst Display method");
        }

        // Explicit implementation of Display for ISecond
        void ISecond.Display()
        {
            Console.WriteLine("ISecond Display method");
        }

        // Implementation of IFirst method
        public int GetValue()
        {
            return 100;
        }

        // Implementation of ISecond method
        public void Demo()
        {
            Console.WriteLine("ISecond Demo method");
        }
    }
}
