using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.BookingDL
{
    internal class DeleteBookingDL
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

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
    }
}
