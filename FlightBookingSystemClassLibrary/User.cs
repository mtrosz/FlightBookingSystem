using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystemClassLibrary
{
    class User
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Country { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsAdult { get; set; }
        public string EmailAdress { get; set; }

        public User()
        {

        }
    }
}
