/*using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.ActivityTypeDL
{
    internal class CreateActivityTypeDL
    {
       
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public static int CreateActivityType(ActivityTypeModel activityType)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.\n");


            string insertSql = $"INSERT INTO ActivityType (ActivityTypeID, InstructorID, ActivityTypeName, ActivityTypeDescription) VALUES (@ActivityTypeID, @InstructorID, @ActivityTypeName, @ActivityTypeDescription)";
            Console.WriteLine($"SQL Command: {insertSql}");
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@ActivityTypeID", activityType.ActivityTypeId);
                insertCmd.Parameters.AddWithValue("@InstructorID", activityType.InstructorId);
                insertCmd.Parameters.AddWithValue("@InstructorID", activityType.ActivityTypeName);
                insertCmd.Parameters.AddWithValue("@PersonalNote", activityType.ActivityTypeDescription);
                
                int rowsChanged = insertCmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsChanged} rækker ændret.");

                int id = (int)insertCmd.ExecuteScalar(); // henter det auto generede ID fra databasen
                return id; // return id 
            }
            
        }
        
    }
}
*/