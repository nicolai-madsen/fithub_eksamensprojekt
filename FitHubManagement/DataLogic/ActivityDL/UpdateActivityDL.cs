/*using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.ActivityDL
{
    internal class UpdateActivityDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        // Alle metoder gør det samme, bare for forskellige kolonner. 
        public static void UpdateActivityType(int activityId, int newValue)
        {
            using SqlConnection connection = new SqlConnection(connectionString); // Vi laver en ny SqlConnection og kalder den "connection". Et SqlConnection objekt skal bruge et parameter,
                                                                                  // som er vores connectionString. Denne string indeholder "adgangs adressen" til vores lokale database.

            connection.Open(); // Åbn connection til database
            Console.WriteLine("Connection to database established."); // Bekræft connection i console

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

        public static void UpdateInstructor(int activityId, int newValue)
        {
    
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Activity SET InstructorID = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateStartDateTime(int activityId, DateTime newValue)
        {
      
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Activity SET StartDateTime = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateDuration(int activityId, string newValue)
        {
      
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Activity SET Duration = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateActivityLocation(int activityId, string newValue)
        {
     
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = $"UPDATE Activity SET ActivityLocation = @newValue WHERE ActivityID = @activityId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@activityId", activityId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateMaxParticipants(int activityId, int newValue)
        {
         
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

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
}*/
