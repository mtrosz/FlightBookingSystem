using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FlightBookingSystemClassLibrary
{
    public class User
    {
        private DateTime dateOfBirth;
        private bool isAdult;
        private MailAddress emailAdress;
        private string password;
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Country { get; set; }
        public string Username { get; set; }
        public string Password
        {
            get
            {
                return password.ToString();
            }
            set
            {
                password = value;
                    //if (CheckPasswordStrenght(value).Equals("Strong") || CheckPasswordStrenght(value).Equals("VeryStrong"))
                    //{
                    //   foreach (char c in value)
                    //        password.AppendChar(c);
                    //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Password is too weak...");
                //}
            }
        }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth.Date;
            }
            set
            {
                if (this.DateOfBirth.AddYears(18) <= DateTime.Today)
                {
                    isAdult = true;
                }
                else
                {
                    isAdult = false;
                }
                dateOfBirth = value.Date;
            }
        }
        public bool IsAdult
        { get
            {
                return isAdult;
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
                    MessageBox.Show("Wrong email adress.");
                }
            }
        }

        public User()
        {

        }

        public virtual PasswordStrength CheckPasswordStrenght(string pass)
        {
            int strength = 1;

            if (pass.Length < 1)
                return PasswordStrength.Blank;
            if (pass.Length < 4)
                return PasswordStrength.VeryWeak;
            if (pass.Length >= 8)
                strength++;
            if (pass.Length >= 12)
                strength++;
            if (Regex.IsMatch(pass, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))
                strength++;
            if (Regex.IsMatch(pass, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript))
                strength++;
            if (Regex.IsMatch(pass, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript))
                strength++;
            return (PasswordStrength)strength;
        }

        public enum PasswordStrength
        {
            Blank = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }
    }
}
