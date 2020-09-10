using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CourtBooking.Service
{
    class Service
    {
        public List<Entities> GetAllBookings()
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString($"https://api.aspitcloud.dk/bookings");

            }

            return JsonConvert.DeserializeObject<List<Entities>>(json);

        }

        public Entities GetOneBooking(int id)
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString($"https://api.aspitcloud.dk/bookings/{id}");

            }

            return JsonConvert.DeserializeObject<Entities>(json);

        }
    }
}
