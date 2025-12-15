using FitHubManagement.Models;
using System.Configuration;
using FitHubManagement.Models.FilterModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    public class ActivityDAL
    {

        //Activity filter

        public List<ActivityFilterModel> GetFilteredActivities(ActivityFilterModel filterModel)
        {
            List<ActivityFilterModel> activities = new List<ActivityFilterModel>();

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
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


        //Create activity

        public int CreateActivity(ActivityModel activity) // Metoden der laver en Activity tager et helt Activity objekt, som har properties med vores data

        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            // string indeholder den kommando der sendes til databasen. String er en Sql kommando, der indsætter en ny Activity i databasen
            string insertSql = @"INSERT INTO Activity (ActivityTypeID, InstructorID, StartDateTime, Duration, ActivityLocation, MaxParticipants)
                                VALUES (@ActivityTypeID, @InstructorID, @StartDateTime, @Duration, @ActivityLocation, @MaxParticipants)
                                SELECT CAST(SCOPE_IDENTITY() AS INT);
                                ";
            Console.WriteLine($"SQL Command: {insertSql}");
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@ActivityTypeID", activity.ActivityTypeId); // Properties i Activity objektet har data. Det data lagres i databasen
                insertCmd.Parameters.AddWithValue("@InstructorID", activity.InstructorId);
                insertCmd.Parameters.AddWithValue("@StartDateTime", activity.StartDateTime);
                insertCmd.Parameters.AddWithValue("@Duration", activity.Duration);
                insertCmd.Parameters.AddWithValue("@ActivityLocation", activity.ActivityLocation);
                insertCmd.Parameters.AddWithValue("@MaxParticipants", activity.MaxParticipant);

                insertCmd.ExecuteNonQuery(); // Returns int, tilsvarende mængden af rækker der blev ændret af den action der lige er blevet lavet.

                int id = (int)insertCmd.ExecuteScalar(); // henter det auto generede ID fra databasen
                return id; // return id 
            }

        }


        //DELETE
        public void DeleteActivity(int activityId)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            // Remove student from database
            string deleteSql = $"DELETE FROM Activity WHERE ActivityID = @activityId"; // SQL kommando der sendes til databasen. Vi bruger @activityId, for sikkerhed.  
            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
            {
                deleteCmd.Parameters.AddWithValue("@ActivityID", activityId); // Så vi binder @ActivityID til metode parameteret activityId

                int deleted = deleteCmd.ExecuteNonQuery();
                Console.WriteLine($"{deleted} rows deleted."); // deleted holder antal rækker der blev ændret af SQL kommando.
            }
        }

        //READ


        // Metode der henter alle aktiviteter fra databasen
        public List<ActivityModel> GetAllActivities()
        {
            // Liste til at gemme alle Activity-objekter
            List<ActivityModel> activityList = new List<ActivityModel>();


            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            string query =
                "SELECT ActivityID, Name, Description, Location, MaxParticipants, StartTime, DurationMinutes, InstructorID, ActivityTypeID " +
                "FROM Activity";


            using SqlCommand command = new SqlCommand(query, connection);

            // Udfører SELECT og får en SqlDataReader
            using SqlDataReader reader = command.ExecuteReader();
            {
                // Går igennem hver række i resultatet
                while (reader.Read())
                {
                    // Håndterer nullable Description (kan være NULL i databasen)
                    string description = null;
                    int descriptionIndex = reader.GetOrdinal("Description");
                    if (!reader.IsDBNull(descriptionIndex))
                    {
                        description = reader.GetString(descriptionIndex);
                    }

                    // Opretter et Activity-objekt og mapper kolonnerne til properties
                    ActivityModel a = new ActivityModel
                    {
                        ActivityId = reader.GetInt32(reader.GetOrdinal("ActivityID")),
                        ActivityTypeId = reader.GetInt32(reader.GetOrdinal("ActivityTypeID")),
                        ActivityLocation = reader.GetString(reader.GetOrdinal("Location")),
                        MaxParticipants = reader.GetInt32(reader.GetOrdinal("MaxParticipants")),
                        StartDateTime = reader.GetDateTime(reader.GetOrdinal("StartTime")),
                        //Duration = reader.GetInt32(reader.GetOrdinal("DurationMinutes")), Skal laves om til dateTime i SQL..
                        InstructorId = reader.GetInt32(reader.GetOrdinal("InstructorID")),

                    };

                    // Lægger Activity-objektet i listen
                    activityList.Add(a);
                }
            }

            // Skriver i konsollen hvor mange aktiviteter der blev hentet
            Console.WriteLine($"Loaded {activityList.Count} activities from database.");

            // Returnerer listen med alle aktiviteter
            return activityList;
        }


        public List<string> GetAllLocations() //Viser forskellige lokationer, der er i databasen
        {

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            var activitylocation = new List<string>();

            string selectSql =
            "SELECT DISTINCT ActivityLocation FROM Activity WHERE ActivityLocation IS NOT NULL AND ActivityLocation <> ''";

            Console.WriteLine($"SQL Command: {selectSql}");
            using (SqlCommand insertCmd = new SqlCommand(selectSql, connection))


            using (SqlDataReader reader = insertCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    activitylocation.Add(reader.GetString(0));
                }
            }


            return activitylocation;
        }

        public List<string> GetAllActivityTypes() //En liste af alle navne på holdtyper. Metoden hører til i ActivityType, men der er ikke oprettet klasser i ActivityType endnu.
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            var activityTypeNameOnly = new List<string>();

            string selectSql = "SELECT ActivityTypeName FROM ActivityType";

            Console.WriteLine($"SQL Command: {selectSql}");
            using (SqlCommand insertCmd = new SqlCommand(selectSql, connection))

            using (SqlDataReader reader = insertCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    activityTypeNameOnly.Add(reader.GetString(0));

                }
            }
            return activityTypeNameOnly;
        }


        public List<string> GetAllDuration() //Viser de forskellige durations, der er i databasen
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            var activityDuration = new List<string>();

            string selectSql =
            "SELECT DISTINCT Duration FROM Activity WHERE Duration IS NOT NULL AND Duration <> ''";

            Console.WriteLine($"SQL Command: {selectSql}");
            using (SqlCommand insertCmd = new SqlCommand(selectSql, connection))


            using (SqlDataReader reader = insertCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    activityDuration.Add(reader.GetString(0));
                }
            }

            return activityDuration;
        }
        

        //UPDATE
        public void UpdateActivityType(int activityId, int newValue)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Activity SET ActivityTypeID = @newValue WHERE ActivityID = @activityId"; // SQL kommando (string sendes til databasen) opdaterer en Activity
                                                                                                                 // ud fra ActivityID, da denne altid er unik.
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue); // Bind parameter til @newValue. 
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public void UpdateInstructor(int activityId, int newValue)
        {

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Activity SET InstructorID = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public void UpdateStartDateTime(int activityId, DateTime newValue)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Activity SET StartDateTime = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public void UpdateDuration(int activityId, string newValue)
        {

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Activity SET Duration = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public void UpdateActivityLocation(int activityId, string newValue)
        {

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Activity SET ActivityLocation = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public void UpdateMaxParticipants(int activityId, int newValue)
        {

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string updateSql = $"UPDATE Activity SET MaxParticipants = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }
    }
}





