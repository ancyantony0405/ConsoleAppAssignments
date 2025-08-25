using ConsoleAppMovie.Model;

namespace ConsoleAppMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieTicket movieTicket = new MovieTicket();
            Console.WriteLine("Movie Ticket Details");
            movieTicket.movieName = "Inception"; // Set movie name
            movieTicket.totalSeats = 100; // Set total seats available
            movieTicket.bookedSeats = 0; // Initialize booked seats
            // Book some seats
            movieTicket.BookSeats(10); // Booking 30 seats
            movieTicket.CancelSeats(5); // Cancel 5 seats
            Console.WriteLine(movieTicket); // Print movie ticket details

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();

        }
    }
}
