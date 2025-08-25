namespace ConsoleAppSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Input distance from the user
            Console.WriteLine(" Enter the distance in km = ");
            double distance = Convert.ToDouble(Console.ReadLine());

            //  Input time from the user
            Console.WriteLine(" Enter the time in hours = ");
            double time = Convert.ToDouble(Console.ReadLine());

            //Calculate speed in km/h
            double speedKph = distance / time;

            // Convert km to miles   
            double distanceMiles = distance * 0.621371;
            double SpeedMilesPerHour = distanceMiles / time;

            //Display to call methods
            DisplayOutput(speedKph, SpeedMilesPerHour);

        }
        private static void DisplayOutput(double Kph, double Mph)
        {
            Console.WriteLine("Speed in km/h:" + (Kph));
            Console.WriteLine($"Speed in miles/h: {Mph}");
        }
    }
}

