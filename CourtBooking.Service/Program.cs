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

            Entities oneBooking = bookingService.GetOneBooking(1);
            
            Console.WriteLine(oneBooking);
        }
    }
}
