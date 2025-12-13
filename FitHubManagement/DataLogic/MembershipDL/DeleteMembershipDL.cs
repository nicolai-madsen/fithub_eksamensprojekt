using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FitHubManagement.DataLogic.MembershipDL
{
    public class DeleteMembershipDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                                "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public int DeleteMembership(int membershipId) // non static, so method can be called on instances of objects
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open(); // connection åbnes.

            string deleteSql = $"DELETE FROM membership WHERE MembershipId = @membershipId"; // Send query til databasen
            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
            {
                deleteCmd.Parameters.AddWithValue("@MembershipId", membershipId);

                int deleted = deleteCmd.ExecuteNonQuery(); 
                return deleted; // Return rows changed for confirmation in UI
            }
        }
    }
}
