using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlightBookingSystemClassLibrary
{
    class Airport : City
    {
        public int AirportID { get; set; }
        public string ICAO { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public void ShowData()
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\FlightBookingSystemDataset.mdf;Integrated Security=True;Connect Timeout=60;Encrypt=False";
                connect.Open();
                Console.WriteLine("Connected...");

                SqlCommand command = new SqlCommand("SELECT * FROM AIRPORTS", connect);
                Console.WriteLine("Command executed...");

                SqlDataReader dataread = command.ExecuteReader();

                while (dataread.Read())
                {
                    Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3} \t | {4} \t | {5}", dataread[0], dataread[1], dataread[2], dataread[3], dataread[4], dataread[5]));
                }

                Console.WriteLine("Finished reading...");
            }
        }
    }
}
