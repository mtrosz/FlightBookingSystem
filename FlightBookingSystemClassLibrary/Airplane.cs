﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystemClassLibrary
{
    class Airplane
    {
        public int AirplaneID { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public int MaxCapacity { get; set; }
        public float CruiseSpeed { get; set; }


        public void ShowData()
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\FlightBookingSystemDataset.mdf;Integrated Security=True;Connect Timeout=60;Encrypt=False";
                connect.Open();
                Console.WriteLine("Connected...");

                SqlCommand command = new SqlCommand("SELECT * FROM AIRPLANES", connect);
                Console.WriteLine("Command executed...");

                SqlDataReader dataread = command.ExecuteReader();

                while (dataread.Read())
                {
                    Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3} \t | {4}", dataread[0], dataread[1], dataread[2], dataread[3], dataread[4]));
                }

                Console.WriteLine("Finished reading...");
            }
        }

    }
}
