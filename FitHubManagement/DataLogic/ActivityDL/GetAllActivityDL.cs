using Microsoft.Data.SqlClient;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitHubManagement.DataLogic.ActivityDL
{
    public class GetAllActivityDL
    {
        // Forbindelsesstreng til databasen
        public static string connectionString =
            "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        // Metode der henter alle aktiviteter fra databasen
        public static List<ActivityModel> GetAllActivities()
        {
            // Liste til at gemme alle Activity-objekter
            List<ActivityModel> activityList = new List<ActivityModel>();

            
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.");

            
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

        public static List<string> GetAllLocations() //Viser forskellige lokationer, der er i databasen
        {
            using SqlConnection connection = new SqlConnection(connectionString); // "Using" giver adgang til alle de metoder som klassen SqlConnection. 
            connection.Open(); // Åben forbindelsen til databasen
            Console.WriteLine("Connection to database established.\n");


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

        public static List<string> GetAllActivityTypes() //En liste af alle navne på holdtyper. Metoden hører til i ActivityType, men der er ikke oprettet klasser i ActivityType endnu.
        {
            using SqlConnection connection = new SqlConnection(connectionString); // "Using" giver adgang til alle de metoder som klassen SqlConnection. 
            connection.Open(); // Åben forbindelsen til databasen
            Console.WriteLine("Connection to database established.\n");

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


        public static List<string> GetAllDuration() //Viser de forskellige durations, der er i databasen
        {
            using SqlConnection connection = new SqlConnection(connectionString); // "Using" giver adgang til alle de metoder som klassen SqlConnection. 
            connection.Open(); // Åben forbindelsen til databasen
            Console.WriteLine("Connection to database established.\n");


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


    }
}

    

