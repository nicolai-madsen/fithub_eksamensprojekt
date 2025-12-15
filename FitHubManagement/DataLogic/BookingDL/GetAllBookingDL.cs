using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FitHubManagement.Models;


namespace FitHubManagement.DataLogic.BookingDL
{
    public class GetAllBookingDL
    {
        // Forbindelsesstreng til databasen
        public static string connectionString =
            "Server=localhost;Database=FitHubDB;" +
                                    "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        //// Henter alle bookinger fra databasen
        //public static List<BookingModel> GetAllBookings()
        //    {
        //        // Liste hvor vi samler alle booking-objekter
        //        List<BookingModel> bookings = new List<BookingModel>();

        //        // Opretter en forbindelse til databasen
        //        using SqlConnection connection = new SqlConnection(connectionString);
        //        connection.Open();
        //        Console.WriteLine("Connection to database established.");


        //        string query = "SELECT BookingID, ClassID, MemberID, PersonalNote FROM Booking";

        //        using SqlCommand command = new SqlCommand(query, connection);

        //        // Læser resultatet af SQL SELECT
        //        using SqlDataReader reader = command.ExecuteReader();
        //        {
        //            // Går gennem hver række i resultatet
        //            while (reader.Read())
        //            {
        //            // 
        //            string personalNote = null; //Vi laver variabel her for feltet kan være Null i databasen.

        //            if (!reader.IsDBNull(reader.GetOrdinal("PersonalNote")))
        //            {
        //                personalNote = reader.GetString(reader.GetOrdinal("PersonalNote"));
        //            }



        //            // Opretter et Booking-objekt baseret på værdierne i rækken
        //            BookingModel bookingList = new BookingModel
        //                {
        //                BookingId = reader.GetInt32(reader.GetOrdinal("BookingID")),
        //                ActivityId = reader.GetInt32(reader.GetOrdinal("ActivityID")),
        //                CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerID")),
        //                    PersonalNote = reader.GetString(reader.GetOrdinal("PersonalNote"))

        //            };

        //                // Tilføjer booking-objektet til listen
        //                bookings.Add(bookingList);
        //            }
        //        }

        //        // Skriver i konsollen hvor mange bookinger blev hentet
        //        Console.WriteLine($"Loaded {bookings.Count} bookings from database.");

        //        // Returnerer listen med bookings
        //        return bookings;
        //    }
        //}
    }
}

