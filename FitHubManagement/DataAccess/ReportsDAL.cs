using FitHubManagement.Models.ReportModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    internal class ReportsDAL
    {
        //__________________________GetAllActiveCustomer()_________________________________________
        public List<ActiveCustomerReportModel> GetAllActiveCustomer()
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            // Vælg felter fra databasen der skal bruges til at fylde rapport-DTO (ActiveCustomerReportModel.cs)
            // For hver Customer hentes også navnet på deres medlemskab (MembershipName) 
            // via JOIN på Membership, baseret på MembershipID. Giver Customer et MembershipName i stedet for ID.
            // Kun vælg aktive medlemmer (Inactive = 0/False)
            string query = @"
                SELECT 
                       c.CustomerID,
                       c.FirstName,
                       c.LastName,
                       m.MembershipName,
                       c.Email,
                       c.CreatedDate
                FROM Customer c
                JOIN Membership m ON c.MembershipID = m.MembershipID
                WHERE c.Inactive = 0";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {

                List<ActiveCustomerReportModel> activeCustomerList = new List<ActiveCustomerReportModel>();
                while (reader.Read())
                {
                    int customerId = Convert.ToInt32(reader["CustomerID"]);
                    string membershipName = Convert.ToString(reader["MembershipName"]);
                    string firstName = Convert.ToString(reader["FirstName"]);
                    string lastName = Convert.ToString(reader["LastName"]);
                    string email = Convert.ToString(reader["Email"]);

                    DateTime dateTime = (DateTime)reader["CreatedDate"];
                    DateOnly createdDate = DateOnly.FromDateTime(dateTime);

                    ActiveCustomerReportModel inactiveCustomer = new ActiveCustomerReportModel
                    {
                        CustomerId = customerId,
                        FirstName = firstName,
                        LastName = lastName,
                        MembershipName = membershipName,
                        Email = email,
                        CreatedDate = createdDate
                    };
                    activeCustomerList.Add(inactiveCustomer);
                }
                return activeCustomerList;

            }
        }
        //_________________________________________________________________________________________

        // Send query til databasen. Query forklaret længere nede
        // Fyld rapport DTO's properties med data fra databasen
        // Smid alle objekter der blev lavet (ét for hver række i databasen der svarer til vores query) ind i en List
        // Return den liste, så den kan bruges andre steder
        public List<PopularActivityReportModel> GetPopularActivities()
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            // Vælg felter fra databasen der skal bruges til at fylde rapport-DTO (PopularActivityReportModel.cs)
            // JOIN ActivityType, så vi får ActivityTypeName i stedet for ID (som er FK til Activity)
            // JOIN Booking, så vi får alle bookinger på hver Activity. LEFT JOIN gør at vi også får hold uden bookinger
            // JOIN Customer, så der kun tælles aktive medlemmer
            // 
            string query = @"
                SELECT 
                    at.ActivityTypeName AS ActivityName,
                    a.StartDateTime,
                    COUNT(b.CustomerID) AS BookingCount
                FROM Activity a
                JOIN ActivityType at ON a.ActivityTypeID = at.ActivityTypeID
                LEFT JOIN Booking b ON b.ActivityID = a.ActivityID
                LEFT JOIN Customer c ON c.CustomerID = b.CustomerID AND c.Inactive = 0
                GROUP BY a.ActivityID, at.ActivityTypeName, a.StartDateTime
                ORDER BY BookingCount DESC;";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {

                List<PopularActivityReportModel> popularActivityList = new List<PopularActivityReportModel>();
                while (reader.Read())
                {
                    var popularActivityModel = new PopularActivityReportModel
                    {
                        ActivityName = reader["ActivityName"].ToString(),
                        StartDateTime = (DateTime)reader["StartDateTime"],
                        BookingCount = Convert.ToInt32(reader["BookingCount"])
                    };
                    popularActivityList.Add(popularActivityModel);
                }
                return popularActivityList;

            }
        }
    }
}
