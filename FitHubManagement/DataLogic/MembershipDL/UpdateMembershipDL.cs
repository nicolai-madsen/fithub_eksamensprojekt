/*using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.MembershipDL
{
    public class UpdateMembershipDL
    {
        public static string connectionString = "Server=.;Database=FitHubDB;" +
                                                "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public int UpdateMembership(MembershipModel membership) // This method might fuck. 
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = @"
                UPDATE Membership
                SET MembershipName = @MembershipName,
                    MembershipDescription = @MembershipDescription,
                    MonthlyPrice = @MonthlyPrice
                WHERE MembershipId = @MembershipId;";

            using SqlCommand UpdateCmd = new SqlCommand(sql, connection);
            UpdateCmd.Parameters.AddWithValue("@MembershipName", membership.MembershipName);
            UpdateCmd.Parameters.AddWithValue("@MembershipDescription", membership.MembershipDescription);
            UpdateCmd.Parameters.AddWithValue("@MonthlyPrice", membership.MonthlyPrice);

            int updatedRows = UpdateCmd.ExecuteNonQuery();
            return updatedRows; // Return rows changed for confirmation in UI
        }

        public int UpdateMembershipName(int membershipId, string newValue)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string updateSql = "UPDATE Membership SET MembershipName = @NewValue WHERE MembershipId = @MembershipId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@NewValue", newValue);
                updateCmd.Parameters.AddWithValue("@MembershipId", membershipId);

                int updated = updateCmd.ExecuteNonQuery();
                return updated;
            }
        }

        public int UpdateMembershipDescription(int membershipId, string newValue)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string updateSql = "UPDATE Membership SET MembershipDescription = @NewValue WHERE MembershipID = @MembershipId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@NewValue", newValue);
                updateCmd.Parameters.AddWithValue("@MembershipId", membershipId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
                return updated;
            }
        }

        public int MembershipMonthlyPrice(int membershipId, string newValue)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string updateSql = "UPDATE Membership SET MonthlyPrice = @NewValue WHERE MembershipId = @MembershipId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@NewValue", newValue);
                updateCmd.Parameters.AddWithValue("@MembershipId", membershipId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
                return updated;
            }
        }
    }
} */
