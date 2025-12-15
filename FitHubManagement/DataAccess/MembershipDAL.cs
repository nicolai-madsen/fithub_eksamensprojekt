using FitHubManagement.Models;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataAccess
{
    public class MembershipDAL
    {
        public static string connectionString =
        ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        //CREATE
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

        //DELETE
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

        //READ
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
    
        public int CreateMembershipRepo(MembershipModel membership)

        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open(); // Åben forbindelsen til databasen
            Console.WriteLine("Connection to database established.\n");



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

        //UPDATE
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
}



