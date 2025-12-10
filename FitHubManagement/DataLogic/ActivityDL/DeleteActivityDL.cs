using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.ActivityDL
{
    internal class DeleteActivityDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"; // Vores "connection nøgle", not actually. Aldrig kald det en nøgle, men man kan se det sådan.

        public static void DeleteActivity(int activityId)
        {
            using SqlConnection connection = new SqlConnection(connectionString); // Lav en ny connection til databasen med SqlConnection klassen.
                                                                                  // Vi laver en ny instans (når der står "= new SqlConnection", så er det en ny instans. Vi laver et objekt)
            connection.Open(); // connection åbnes.
            Console.WriteLine("Connection to database established.");

            // Remove student from database
            string deleteSql = $"DELETE FROM Activity WHERE ActivityID = @activityId"; // SQL kommando der sendes til databasen. Vi bruger @activityId, for sikkerhed.  
            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
            {
                deleteCmd.Parameters.AddWithValue("@ActivityID", activityId); // Så vi binder @ActivityID til metode parameteret activityId

                int deleted = deleteCmd.ExecuteNonQuery();
                Console.WriteLine($"{deleted} rows deleted."); // deleted holder antal rækker der blev ændret af SQL kommando.
            }
        }
    }
}
