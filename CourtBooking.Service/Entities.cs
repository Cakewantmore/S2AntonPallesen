using System;
using System.Collections.Generic;
using System.Text;

namespace CourtBooking.Service
{
    class Entities
    {
        private int id;
        private int courtNumber;
        private string bookingTime;
        private string booker;



        public int Id { get => id; set => id = value; }
        public int CourtNumber { get => courtNumber; set => courtNumber = value; }
        public string BookingTime { get => bookingTime; set => bookingTime = value; }
        public string Booker { get => booker; set => booker = value; }
        public Entities(int id, int courtNumber, string bookingTime, string booker)
        {
            Id = id;
            CourtNumber = courtNumber;
            BookingTime = bookingTime;
            Booker = booker;
        }

        public override string ToString()
        {
            return $"{CourtNumber} {bookingTime} {booker}";
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          

    }
}
