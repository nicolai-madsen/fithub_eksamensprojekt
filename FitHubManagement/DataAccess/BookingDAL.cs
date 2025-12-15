using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataAccess
{
    internal class BookingDAL
    {
        public static string connectionString =
        ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // CREATE
        public static void CreateBooking(int activityId, int customerId, string personalNote)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.\n");


            string insertSql = $"INSERT INTO Booking (ActivityID, CustomerID, PersonalNote) VALUES (@ActivityID, @CustomerID, @PersonalNote)";
            Console.WriteLine($"SQL Command: {insertSql}");
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@ActivityID", activityId);
                insertCmd.Parameters.AddWithValue("@CustomerID", customerId);
                insertCmd.Parameters.AddWithValue("@PersonalNote", personalNote);
                insertCmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public static void DeleteBooking(int bookingId)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.");

            // Remove student from database
            string deleteSql = $"DELETE FROM Booking WHERE BookingID = @bookingId";
            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
            {
                deleteCmd.Parameters.AddWithValue("@ActivityID", bookingId);

                int deleted = deleteCmd.ExecuteNonQuery();
                Console.WriteLine($"{deleted} rows deleted.");
            }
        }

        // Henter alle bookinger fra databasen
        public static List<BookingModel> GetAllBookings()
        {
            // Liste hvor vi samler alle booking-objekter
            List<BookingModel> bookings = new List<BookingModel>();

            // Opretter en forbindelse til databasen
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.");


            string query = "SELECT BookingID, ClassID, MemberID, PersonalNote FROM Booking";

            using SqlCommand command = new SqlCommand(query, connection);

            // Læser resultatet af SQL SELECT
            using SqlDataReader reader = command.ExecuteReader();
            {
                // Går gennem hver række i resultatet
                while (reader.Read())
                {
                    // 
                    string personalNote = null; //Vi laver variabel her for feltet kan være Null i databasen.

                    if (!reader.IsDBNull(reader.GetOrdinal("PersonalNote")))
                    {
                        personalNote = reader.GetString(reader.GetOrdinal("PersonalNote"));
                    }

                    // Opretter et Booking-objekt baseret på værdierne i rækken
                    BookingModel bookingList = new BookingModel
                    {
                        BookingId = reader.GetInt32(reader.GetOrdinal("BookingID")),
                        ActivityId = reader.GetInt32(reader.GetOrdinal("ActivityID")),
                        CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                        PersonalNote = reader.GetString(reader.GetOrdinal("PersonalNote"))

                    };

                    // Tilføjer booking-objektet til listen
                    bookings.Add(bookingList);
                }
            }

            // Skriver i konsollen hvor mange bookinger blev hentet
            Console.WriteLine($"Loaded {bookings.Count} bookings from database.");

            // Returnerer listen med bookings
            return bookings;
        }

        public static void UpdateActivity(int bookingId, int newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Booking SET ActivityID = @newValue WHERE BookingID = @bookingId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@bookingId", bookingId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateCustomer(int bookingId, int newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Booking SET CustomerID = @newValue WHERE BookingID = @bookingId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", bookingId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdatePersonalNote(int bookingId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Booking SET PersonalNote = @newValue WHERE BookingID = @bookingId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", bookingId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }
    }
}

