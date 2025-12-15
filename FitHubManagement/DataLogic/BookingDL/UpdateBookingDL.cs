using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.BookingDL
{
    internal class UpdateBookingDL
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FitHubDB;" +
           "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        //public static void UpdateActivity(int bookingId, int newValue)
        //{
        //    // Open connection first
        //    using SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    Console.WriteLine("Connection to database established.");

        //    string updateSql = $"UPDATE Booking SET ActivityID = @newValue WHERE BookingID = @bookingId";
        //    using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
        //    {
        //        updateCmd.Parameters.AddWithValue("@newValue", newValue);
        //        updateCmd.Parameters.AddWithValue("@bookingId", bookingId);

        //        int updated = updateCmd.ExecuteNonQuery();
        //        Console.WriteLine($"{updated} rows updated.");
        //    }
        //}

        //public static void UpdateCustomer(int bookingId, int newValue)
        //{
        //    // Open connection first
        //    using SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    Console.WriteLine("Connection to database established.");

        //    string updateSql = $"UPDATE Booking SET CustomerID = @newValue WHERE BookingID = @bookingId";
        //    using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
        //    {
        //        updateCmd.Parameters.AddWithValue("@newValue", newValue);
        //        updateCmd.Parameters.AddWithValue("@customerId", bookingId);

        //        int updated = updateCmd.ExecuteNonQuery();
        //        Console.WriteLine($"{updated} rows updated.");
        //    }
        //}

        //public static void UpdatePersonalNote(int bookingId, string newValue)
        //{
        //    // Open connection first
        //    using SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    Console.WriteLine("Connection to database established.");

        //    string updateSql = $"UPDATE Booking SET PersonalNote = @newValue WHERE BookingID = @bookingId";
        //    using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
        //    {
        //        updateCmd.Parameters.AddWithValue("@newValue", newValue);
        //        updateCmd.Parameters.AddWithValue("@customerId", bookingId);

        //        int updated = updateCmd.ExecuteNonQuery();
        //        Console.WriteLine($"{updated} rows updated.");
        //    }
        //}
    }
}
