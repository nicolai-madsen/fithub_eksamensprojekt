using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.InstructorDL
{
    public class UpdateInstructorDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public static void UpdateFirstName(int instructorId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = "UPDATE Instructor SET FirstName = @newValue WHERE InstructorID = @instructorId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateLastName(int instructorId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = "UPDATE Instructor SET LastName = @newValue WHERE InstructorID = @instructorId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateEmail(int instructorId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = "UPDATE Instructor SET Email = @newValue WHERE InstructorID = @instructorId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdatePhone(int instructorId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = "UPDATE Instructor SET Phone = @newValue WHERE InstructorID = @instructorId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }
    }
}
