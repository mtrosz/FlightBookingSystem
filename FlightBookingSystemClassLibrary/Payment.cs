using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystemClassLibrary
{
    public class Payment
    {
        public int ReservationID { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime PaymentDate { get; set; }
        public enum PaymentStatus
        {
            canceled,
            compplete,
            processing
        }
        public Payment()
        {

        }
    }
}
