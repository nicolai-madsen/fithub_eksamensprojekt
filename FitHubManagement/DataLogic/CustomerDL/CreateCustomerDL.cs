using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FitHubManagement.DataLogic.CustomerDL
{
    internal class CreateCustomerDL
    {

        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FitHubDB;" +
                                         "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public static void CreateCustomer(int membershipId, string firstName, string lastName, string email, string phone, DateTime birthday, string personalNote)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.\n");


            string insertSql = $"INSERT INTO Customer (MembershipID, FirstName, LastName, Email, Phone, Birthday, PersonalNote) VALUES (@MembershipID, @FirstName, @LastName, @Email, @Phone, @Birthday, @PersonalNote)";
            Console.WriteLine($"SQL Command: {insertSql}");
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@MembershipID", membershipId);
                insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                insertCmd.Parameters.AddWithValue("@LastName", lastName);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.Parameters.AddWithValue("@Phone", phone);
                insertCmd.Parameters.AddWithValue("@Birthday", birthday);
                insertCmd.Parameters.AddWithValue("@PersonalNote", personalNote);

                int changed = insertCmd.ExecuteNonQuery(); // Tæller mængden af rows der blev ændret af Sql kommando
                Console.WriteLine($"Created {changed} new Customer.");
            }
        }
        
    }
}
