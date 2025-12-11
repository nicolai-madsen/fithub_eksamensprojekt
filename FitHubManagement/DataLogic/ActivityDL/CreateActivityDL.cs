using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FitHubManagement.Models;

namespace FitHubManagement.DataLogic.ActivityDL
{
    internal class CreateActivityDL
    {
        public static string connectionString = "Server=.;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"; // string bruges til at oprette forbindelse til selve databasen
        public static int CreateActivity(ActivityModel activity) // Metoden der laver en Activity tager et helt Activity objekt, som har properties med vores data

        {
            using SqlConnection connection = new SqlConnection(connectionString); // "Using" giver adgang til alle de metoder som klassen SqlConnection. 
            connection.Open(); // Åben forbindelsen til databasen
            Console.WriteLine("Connection to database established.\n");


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
    }
}
