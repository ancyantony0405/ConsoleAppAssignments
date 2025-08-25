using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProductManagement.Model
{
    //fields
    public class Product
    {
        public string productName;
        public double price;
        public int stockQuantity;


        //default constructor   
    public Product()
        {

        }
    

     //methods
     public void AddStock(int quantity)
        {
            if (quantity > 0)
            {
                stockQuantity += quantity;
                Console.WriteLine($"{quantity} items added and new stock: {stockQuantity}");
            }
            else
            {
                Console.WriteLine("Invalid quantity");
            }
        }

    public void Sell(int quantity)
        {
            if (quantity > 0 && quantity <= stockQuantity)
            {
                stockQuantity -= quantity;
                Console.WriteLine($"{quantity} items sold and remaining stock: {stockQuantity}");
            }
            else
            {
                Console.WriteLine("Invalid quantity");
            }
        }

        //ToString method
        public override string? ToString()
        {
            return $"Product: {productName}, Price: {price}, Stock: {stockQuantity}";
        }

    }
}
