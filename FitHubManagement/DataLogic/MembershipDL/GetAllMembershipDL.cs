/*using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.MembershipDL
{
    public class GetAllMembershipDL
    {
        public static string connectionString = "Server=.;Database=FitHubDB;" +
                                                "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public MembershipModel GetMembership(int membershipId)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string selectSql = "SELECT MembershipID, MembershipName, MembershipDescription, MonthlyPrice" +
                               "FROM Membership WHERE MembershipID = @MembershipId";
            using (SqlCommand selectCmd = new SqlCommand(selectSql, connection))
            {
                selectCmd.Parameters.AddWithValue("@MembershipId", membershipId);

                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {
                        MembershipModel membership = new MembershipModel
                        {
                            MembershipId = reader.GetInt32(0),
                            MembershipName = reader.GetString(1),
                            MembershipDescription = reader.GetString(2),
                            MonthlyPrice = reader.GetDecimal(3),
                        };
                    return membership;
                }
            }
        }
        public List<MembershipModel> GetAllMembership()
        {
            List<MembershipModel> memberships = new List<MembershipModel>();

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string selectSql = "SELECT MembershipID, MembershipName, MembershipDescription, MonthlyPrice FROM Membership";
            using SqlCommand selectCmd = new SqlCommand(selectSql, connection);
            using SqlDataReader reader = selectCmd.ExecuteReader();

            while (reader.Read())
            {
                MembershipModel membership = new MembershipModel
                {
                    MembershipId = reader.GetInt32(0),
                    MembershipName = reader.GetString(1),
                    MembershipDescription = reader.GetString(2),
                    MonthlyPrice = reader.GetDecimal(3),
                };

                memberships.Add(membership);
            }

            return memberships;
        }
    }
}*/
