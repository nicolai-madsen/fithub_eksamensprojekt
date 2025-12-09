using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.CustomerDL
{
    internal class UpdateCustomerDL
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FitHubDB;" +
            "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public static void UpdateMembership(int customerId, int newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Customer SET Membership = @newValue WHERE CustomerID = @customerId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateFirstName(int customerId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Customer SET FirstName = @newValue WHERE CustomerID = @customerId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateLastName(int customerId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Customer SET LastName = @newValue WHERE CustomerID = @customerId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateEmail(int customerId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Customer SET Email = @newValue WHERE CustomerID = @customerId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdatePhone(int customerId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Customer SET Email = @newValue WHERE CustomerID = @customerId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateBirthday(int customerId, DateTime newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Customer SET Birthday = @newValue WHERE CustomerID = @customerId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdatePersonalNote(int customerId, string newValue)
        { 
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Customer SET PersonalNote = @newValue WHERE CustomerID = @customerId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void ChangeCustomerActiveStatus(int customerId, bool newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Customer SET IsActive = @newValue WHERE CustomerID = @customerId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }
    }
}
