using ConsoleAppProductManagement.Model;

namespace ConsoleAppClassAndObjectAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Console.WriteLine("Product Details");
            product.productName = "Laptop"; // Set product name
            product.price = 1500.00; // Set product price
            product.stockQuantity = 100; // Set initial stock quantity
            // Set product details
            product.AddStock(50); // Adding stock
            product.Sell(20); // Selling some stock
            Console.WriteLine(product);

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();

        }
    }
}
