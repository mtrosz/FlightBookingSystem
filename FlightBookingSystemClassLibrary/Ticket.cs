using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystemClassLibrary
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int ReservationID { get; set; }
        public DateTime FlightTime { get; set; }
        public DateTime TicketConfirmationDate { get; set; }
        public double Price { get; set; }
        public int SeatNumber { get; set; }
        public Ticket()
        {

        }
    }
}
