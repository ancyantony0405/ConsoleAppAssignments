namespace ConsoleAppElectricityBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the customerId : ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the customerName : ");
            string customerName = Console.ReadLine();

            Console.Write("Enter the unit consumed : ");
            double unit = Convert.ToDouble(Console.ReadLine());

            double rate = 0;
            double totalAmount = 0;

            if (unit <= 199)
                rate = 1.20;
            else if (unit == 200 && unit > 400)
                rate = 1.50;
            else if (unit == 400 && unit > 600)
                rate = 1.80;
            else
                rate = 2.00;

            totalAmount = unit * rate;

            Console.WriteLine($"Units Consumed: {unit}");
            Console.WriteLine($"Charge per Unit: Rs.{rate:F2}");
            Console.WriteLine($"Total Amount  : Rs.{totalAmount:F2}");
        }
    }
}
