using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHubManagement.Models;
using Microsoft.Data.SqlClient;

namespace FitHubManagement.DataLogic.CustomerDL
{
    internal class CreateCustomerDL
    {

        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public void CreateCustomer(CustomerModel customer)
        {
            SqlConnection connection = this.connection();

            string insertSql = $"INSERT INTO Customer (MembershipID, FirstName, LastName, Email, Phone, Birthday, PersonalNote) VALUES (@MembershipID, @FirstName, @LastName, @Email, @Phone, @Birthday, @PersonalNote)";
            Console.WriteLine($"SQL Command: {insertSql}");
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@MembershipID", customer.CustomerId);
                insertCmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                insertCmd.Parameters.AddWithValue("@LastName", customer.LastName);
                insertCmd.Parameters.AddWithValue("@Email", customer.Email);
                insertCmd.Parameters.AddWithValue("@Phone", customer.Phone);
                insertCmd.Parameters.AddWithValue("@Birthday", customer.Birthday);
                insertCmd.Parameters.AddWithValue("@PersonalNote", customer.PersonalNote);

                int changed = insertCmd.ExecuteNonQuery(); // Tæller mængden af rows der blev ændret af Sql kommando
                Console.WriteLine($"Created {changed} new Customer.");
            }
        }

        #region helper metoder
        private SqlConnection connection()
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.\n");
            return connection;
        }
        #endregion
    }
}
