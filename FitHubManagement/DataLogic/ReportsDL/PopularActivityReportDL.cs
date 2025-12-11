using FitHubManagement.Models.ReportModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.ReportsDL
{
    internal class PopularActivityReportDL
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FitHubDB;Integrated Security=True;Connect " +
                                                "Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        // Opret forbindelse til databasen
        // Send query til databasen. Query forklaret længere nede
        // Fyld rapport DTO's properties med data fra databasen
        // Smid alle objekter der blev lavet (ét for hver række i databasen der svarer til vores query) ind i en List
        // Return den liste, så den kan bruges andre steder
        public static List<PopularActivityReportModel> GetPopularActivities()
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            Console.WriteLine("Connection to database established.");

            // Vælg felter fra databasen der skal bruges til at fylde rapport-DTO (PopularActivityReportModel.cs)
            // JOIN ActivityType, så vi får ActivityTypeName i stedet for ID (som er FK til Activity)
            // JOIN Booking, så vi får alle bookinger på hver Activity. LEFT JOIN gør at vi også får hold uden bookinger
            // JOIN Customer, så der kun tælles aktive medlemmer
            // 
            string query = @"
                SELECT 
                    at.ActivityTypeName AS ActivityName,
                    a.ActivityDate,
                    a.StartTime,
                    a.EndTime,
                    COUNT(b.CustomerID) AS BookingCount
                FROM Activity a
                JOIN ActivityType at ON a.ActivityTypeID = at.ActivityTypeID
                LEFT JOIN Booking b ON b.ActivityID = a.ActivityID
                LEFT JOIN Customer c ON c.CustomerID = b.CustomerID AND c.Inactive = 0
                GROUP BY a.ActivityID, at.ActivityTypeName, a.ActivityDate, a.StartTime, a.EndTime
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
                        ActivityDate = DateOnly.FromDateTime((DateTime)reader["ActivityDate"]),
                        StartTime = TimeOnly.FromTimeSpan((TimeSpan)reader["StartTime"]),
                        EndTime = TimeOnly.FromTimeSpan((TimeSpan)reader["EndTime"]),
                        BookingCount = Convert.ToInt32(reader["BookingCount"])
                    };
                    popularActivityList.Add(popularActivityModel);
                }
                return popularActivityList;

            }
        }
    }
}
