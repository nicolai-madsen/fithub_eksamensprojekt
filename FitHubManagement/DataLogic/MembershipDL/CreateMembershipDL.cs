/*using Microsoft.Data.SqlClient;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.MembershipDL
{
    public class CreateMembershipDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                                "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"; 
        public int CreateMembership(MembershipModel membership) 
        {
            using SqlConnection connection = new SqlConnection(connectionString); 
            connection.Open(); // Åben forbindelsen til databasen

            string insertSql = @"INSERT INTO Membership (MembershipName, MembershipDescription, MonthlyPrice)
                                VALUES (@MembershipName, @MembershipDescription, @MonthlyPrice)
                                SELECT CAST(SCOPE_IDENTITY() AS INT);"; // Identity auto increments, we have no idea what ID is before row is created.

            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@MembershipName", membership.MembershipName); 
                insertCmd.Parameters.AddWithValue("@MembershipDescription", membership.MembershipDescription);
                insertCmd.Parameters.AddWithValue("@MonthlyPrice", membership.MonthlyPrice);

                int id = (int)insertCmd.ExecuteScalar(); // ExecuteScalar returns ID from newly created row from "insertSql"
                return id; // send to BL to use for confirmation
            }
        }
    }
    }
*/