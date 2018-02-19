using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystemClassLibrary
{
    public class Reservation
    {
        public string UserName { get; set; }
        public int ReservationID { get; set; }
        public DateTime ReservationDate { get; set; }
        public ReservationStatus Status { get; set; }

        public enum ReservationStatus
        {
            canceled,
            confirmed
        }
        public Reservation()
        {

        }
    }
}
