using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMovie.Model
{
    //movieName (string), totalSeats (int), bookedSeats (int)
    public class MovieTicket
    {
        public string movieName;
        public int totalSeats;
        public int bookedSeats;

        // Default constructor
        public MovieTicket()
        {
            movieName = "Unknown";
            totalSeats = 0;
            bookedSeats = 0;
        }

        //methods
        //BookSeats(int seats) (only if seats available)
        public void BookSeats(int seats)
        {
            if (seats > 0 && (bookedSeats + seats) <= totalSeats)
            {
                bookedSeats += seats;
                Console.WriteLine($"{seats} seats booked successfully. Total booked seats: {bookedSeats}");
            }
            else
            {
                Console.WriteLine("Booking failed! Not enough available seats.");
            }
        }

        //CancelSeats(int seats) (cannot cancel more than booked)
        public void CancelSeats(int seats)
        {
            if (seats > 0 && bookedSeats >= seats)
            {
                bookedSeats -= seats;
                Console.WriteLine($"{seats} seats cancelled successfully. Total booked seats: {bookedSeats}");
            }
            else
            {
                Console.WriteLine("Cancellation failed! Cannot cancel more than booked seats.");
            }
        }

        //ToString() method
        public override string? ToString()
        {
            return $"Movie: {movieName}, Total Seats: {totalSeats}, " +
                   $"Booked Seats: {bookedSeats}, " +
                   $"Available Seats: {totalSeats - bookedSeats}";
        }
    }
}
