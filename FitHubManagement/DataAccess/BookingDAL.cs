using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    internal class BookingDAL
    {

        // CREATE
        public void CreateBooking(BookingModel newBooking)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            string insertSql = $"INSERT INTO Booking (ActivityID, CustomerID, PersonalNote) VALUES (@ActivityID, @CustomerID, @PersonalNote)";
            Console.WriteLine($"SQL Command: {insertSql}");
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@ActivityID", newBooking.ActivityId);
                insertCmd.Parameters.AddWithValue("@CustomerID", newBooking.CustomerId);
                insertCmd.Parameters.AddWithValue("@PersonalNote", (object)newBooking.PersonalNote ?? DBNull.Value);//Håndterer null værdier:perosonalNote kan være null
                insertCmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public static void DeleteBooking(int bookingId)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

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

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string query = "SELECT BookingID, ActivityID, CustomerID, PersonalNote FROM Booking"; //Redigeret af LENA


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
                        PersonalNote = personalNote //Sætter personalNote til objektet, da det kan være null

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

        public int GetBookingCountForCustomer(int customerId, DateTime weekStart)
        {
            DateTime weekEnd = weekStart.AddDays(7);

            using (SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                connection.Open();

                string query = @" 
                    SELECT COUNT(*)
                    FROM Booking b 
                    JOIN Activity a ON b.ActivityID = a.ActivityID 
                    WHERE b.CustomerId = @CustomerId 
                    AND a.StartDateTime >= @WeekStart 
                    AND a.StartDateTime < DATEADD(day, 7, @WeekStart)
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@WeekStart", weekStart.Date);

                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }
        }

        #region UPDATE METHODS
        public static void UpdateActivity(int bookingId, int newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

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
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

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
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Booking SET PersonalNote = @newValue WHERE BookingID = @bookingId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", bookingId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }
        #endregion


        //LENA
        // Denne metode finder ud af, hvor mange ledige pladser der er på et hold
        // Den bruges til acceptkriterium 1: tjek om der er ledige pladser
        public  int GetAvailableSpots(int activityId) //En static metode, der tager et activityId som parameter og returnerer et heltal?
        {
            // Opretter forbindelse til databasen
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);

            // Åbner forbindelsen
            connection.Open();

            // SQL-forespørgsel:
            // Vi tager MaxParticipants fra Activity
            // og trækker antallet af bookinger (COUNT) fra Booking
            string sql = @"
        SELECT (a.MaxParticipants - COUNT(b.BookingID)) AS AvailableSpots
        FROM Activity a
        LEFT JOIN Booking b ON b.ActivityID = a.ActivityID
        WHERE a.ActivityID = @ActivityID
        GROUP BY a.MaxParticipants";

            // Opretter SQL-kommandoen med forespørgslen og forbindelsen
            using SqlCommand cmd = new SqlCommand(sql, connection);

            // Tilføjer parameteren ActivityID for at undgå SQL injection
            cmd.Parameters.AddWithValue("@ActivityID", activityId);

            // ExecuteScalar bruges, fordi vi kun forventer ét tal tilbage
            object result = cmd.ExecuteScalar();

            // Hvis der ikke kommer noget resultat tilbage, returnerer vi 0
            if (result == null)
                return 0;

            // Konverterer resultatet til int og returnerer antallet af ledige pladser
            return Convert.ToInt32(result);
        }


    }
}

