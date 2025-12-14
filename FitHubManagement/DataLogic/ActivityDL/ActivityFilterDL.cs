using FitHubManagement.Models.FilterModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.ActivityDL
{
    /// <summary>
    /// Creates a list of activities, matching search criteria, contained in the ActivityFilterModel. 
    /// Model holds data from UI input. Method makes a query to database based on the data in the FilterModel.
    /// User selects "location", or whatever, in UI. if-block is triggered with "=!" (is not) and WHERE is added, 
    /// returning only the Activity matching the search criteria
    /// </summary>

    public class ActivityFilterDL
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FitHubDB;Trusted_Connection=True;";

        public List<ActivityFilterModel> GetFilteredActivities(ActivityFilterModel filterModel)
        {
            List<ActivityFilterModel> activities = new List<ActivityFilterModel>();

            using SqlConnection connection = new SqlConnection(connectionString); 
            connection.Open();
            
            
            // Får stadig Activity selvom den ikke har nogen ActivityTypeID med LEFT JOIN 
            // Split StartDateTime & EndDateTime op i dato og klokkeslæt

            //INNER JOIN fordi LEFT JOIN giver tomme rækker, og rækker kan ikke være tomme. En Activity har altid en ActivityType osv. ActivityType har Instructor
            string filterQuery = @"
                SELECT
	                ActivityID,
	                CAST(StartDateTime AS DATE) AS ActivityDate,
	                CAST(StartDateTime AS TIME) AS StartTime,
	                CAST (EndDateTime AS TIME) AS EndTime,
	                a.ActivityLocation,
	                at.ActivityTypeName,
	                i.FirstName + ' ' + i.LastName AS InstructorName
                FROM Activity a
                INNER JOIN ActivityType at ON a.ActivityTypeID = at.ActivityTypeID 
                INNER JOIN Instructor i ON at.InstructorID = i.InstructorID
                WHERE 1=1
            ";


            using SqlCommand command = new SqlCommand(filterQuery, connection);
            // Tilføjer "WHERE" til filterQuery, hvis property ikke er null/tom.
            // Hvis en af properties i filter modellen er udfyldt, så indsættes det som filter kriterie, ved at tilføje til WHERE
            if (filterModel.ActivityLocation != null && filterModel.ActivityLocation != "") 
            {
                filterQuery += " AND a.ActivityLocation = @ActivityLocation";
                command.Parameters.AddWithValue("@ActivityLocation", filterModel.ActivityLocation);
            }

            if (filterModel.ActivityTypeName != null && filterModel.ActivityTypeName != "")
            {
                filterQuery += " AND at.ActivityTypeName = @ActivityTypeName";
                command.Parameters.AddWithValue("@ActivityTypeName", filterModel.ActivityTypeName);
            }

            if (filterModel.InstructorName != null && filterModel.InstructorName != "")
            {
                filterQuery += " AND (i.FirstName + ' ' + i.LastName) = @InstructorName";
                command.Parameters.AddWithValue("@InstructorName", filterModel.InstructorName);
            }

            if (filterModel.ActivityDate.HasValue)
            {
                filterQuery += " AND CAST(StartDateTime AS DATE) = @ActivityDate";
                command.Parameters.AddWithValue("@ActivityDate", filterModel.ActivityDate.Value.ToDateTime(TimeOnly.MinValue)); // Konvertér DateOnly til DateTime, som DB også bruger
            }

            if (filterModel.StartTime.HasValue)
            {
                filterQuery += " AND CAST(StartDateTime AS TIME) >= @StartTime";
                command.Parameters.AddWithValue("@StartTime", filterModel.StartTime.Value);
            }

            if (filterModel.EndTime.HasValue) 
            {
                filterQuery += " AND CAST(EndDateTime AS TIME) <= @EndTime";
                command.Parameters.AddWithValue("@EndTime", filterModel.EndTime.Value);
            }

            command.CommandText = filterQuery;

            using SqlDataReader reader = command.ExecuteReader();
            // Fyld filter modeller med resultater af filtrering og return listen, så den kan modtages i BL
            while (reader.Read())
            {
                ActivityFilterModel activity = new ActivityFilterModel();

                activity.ActivityId = (int)reader["ActivityID"];
                activity.ActivityDate = DateOnly.FromDateTime((DateTime)reader["ActivityDate"]);
                activity.StartTime = TimeOnly.FromTimeSpan((TimeSpan)reader["StartTime"]);
                activity.EndTime = TimeOnly.FromTimeSpan((TimeSpan)reader["EndTime"]);
                activity.ActivityLocation = reader["ActivityLocation"].ToString();
                activity.ActivityTypeName = reader["ActivityTypeName"].ToString();
                activity.InstructorName = reader["InstructorName"].ToString();

                activities.Add(activity);
            }
            return activities;
        }
    }
}
