using System;
using System.Collections.Generic;

namespace CourtBooking.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Service bookingService = new Service();

            List<Entities> bookings = bookingService.GetAllBookings();
            foreach (Entities kage in bookings)
            {
                Console.WriteLine(kage);
            }
            Console.WriteLine(bookings[1]);
        }
    }
}
