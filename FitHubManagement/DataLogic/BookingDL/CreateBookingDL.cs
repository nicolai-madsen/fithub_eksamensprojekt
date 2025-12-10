using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.BookingDL
{
    internal class CreateBookingDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
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
    }
}
