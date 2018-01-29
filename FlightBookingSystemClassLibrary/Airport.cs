using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystemClassLibrary
{
    class Airport
    {
        public string ICAO { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Continent { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

}
