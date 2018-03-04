using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystemClassLibrary
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }

        public void ShowData()
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\FlightBookingSystemDataset.mdf;Integrated Security=True;Connect Timeout=60;Encrypt=False";
                connect.Open();
                Console.WriteLine("Connected...");

                SqlCommand command = new SqlCommand("SELECT * FROM CITIES", connect);
                Console.WriteLine("Command executed...");

                SqlDataReader dataread = command.ExecuteReader();

                while (dataread.Read())
                {
                    Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}", dataread[0], dataread[1], dataread[2], dataread[3]));
                }

                Console.WriteLine("Finished reading...");
            }
        }
    }
}
