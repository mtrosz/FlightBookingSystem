using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace FlightBookingSystemClassLibrary
{
    public class User
    {
        private DateTime dateOfBirth;
        private bool isAdult;
        private MailAddress emailAdress;
        private SecureString password;
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Country { get; set; }
        public string Username { get; set; }
        public string Password
        {
            get
            {
                string unautorized = "Unautorized"
                return unautorized;
            }
            set
            {
                password = value.;
            }
        }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (this.DateOfBirth.AddYears(18) > DateTime.Today)
                {
                    isAdult = true;
                }
                else
                {
                    isAdult = false;
                }
            }
        }

        public string EmailAdress
        {
            get
            {
                try
                {
                    return emailAdress.ToString();
                }
                catch (Exception)
                {
                    string s = "Something went wrong... There's no email adress assigned to your profile.";
                    return s;
                }
            }
            set
            {
                try
                {
                    emailAdress = new MailAddress(value);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong email adress.");
                }
            }
        }

        public User()
        {

        }
    }
}
