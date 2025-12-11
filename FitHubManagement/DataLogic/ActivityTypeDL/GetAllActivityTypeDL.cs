using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.ActivityTypeDL
{
    public class GetAllActivityTypeDL
    {

        // Forbindelsesstreng til databasen
        public static string connectionString =
            "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        // Metode der henter alle aktiviteter fra databasen
        public static List<ActivityTypeModel> GetAllActivityTypes()
        {
            // Liste til at gemme alle Activity-objekter
            List<ActivityTypeModel> activityTypeList = new List<ActivityTypeModel>();


            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.");


            string query =
                "SELECT ActivityTypeID, InstructorID, ActivityTypeName, ActivityTypeDescription" +
                "FROM ActivityType";


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

                    // Opretter et ActivityType-objekt og mapper kolonnerne til properties
                    ActivityTypeModel a = new ActivityTypeModel
                    {
                        ActivityTypeId = reader.GetInt32(reader.GetOrdinal("ActivityTypeID")),
                        InstructorId = reader.GetInt32(reader.GetOrdinal("InstructorID")),
                        ActivityTypeName = reader.GetString(reader.GetOrdinal("ActivityTypeName")),
                        ActivityTypeDescription = reader.GetString(reader.GetOrdinal("ActivityTypeDescription"))
                    };

                    // Lægger Activity-objektet i listen
                    activityTypeList.Add(a);
                }
            }

            // Skriver i konsollen hvor mange aktiviteter der blev hentet
            Console.WriteLine($"Loaded {activityTypeList.Count} activities from database.");

            // Returnerer listen med alle aktiviteter
            return activityTypeList;
        }

    }
}

