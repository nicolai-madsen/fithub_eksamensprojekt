using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    internal class ActivityTypeDAL
    {
        // 🔹 CREATE ActivityType
        public static int CreateActivityType(ActivityTypeModel activityType)
        {
            using SqlConnection connection =
                new SqlConnection(DatabaseConfig.ConnectionString);

            connection.Open();

            string sql = @"
                INSERT INTO ActivityType
                (InstructorID, ActivityTypeName, ActivityTypeDescription)
                VALUES
                (@InstructorID, @Name, @Description);
                SELECT SCOPE_IDENTITY();
            ";

            using SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@InstructorID", activityType.InstructorId);
            cmd.Parameters.AddWithValue("@Name", activityType.ActivityTypeName);
            cmd.Parameters.AddWithValue("@Description", activityType.ActivityTypeDescription);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<ActivityTypeModel> ReadAllActivityTypes()
        {
            List<ActivityTypeModel> activityTypes = new();

            using SqlConnection conn =
                new SqlConnection(DatabaseConfig.ConnectionString);

            conn.Open();

            string sql = "SELECT ActivityTypeID, ActivityTypeName FROM ActivityType";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                activityTypes.Add(new ActivityTypeModel
                {
                    ActivityTypeId = reader.GetInt32(0),
                    ActivityTypeName = reader.GetString(1)
                });
            }

            return activityTypes;
        }

        


        // 🔹 READ – kun navne (til ComboBox)
        /* public static List<string> ReadAllActivityTypes()
         {
             List<string> activityTypes = new();

             using SqlConnection connection =
                 new SqlConnection(DatabaseConfig.ConnectionString);

             connection.Open();

             string sql = "SELECT ActivityTypeName FROM ActivityType";

             using SqlCommand cmd = new SqlCommand(sql, connection);
             using SqlDataReader reader = cmd.ExecuteReader();

             while (reader.Read())
             {
                 activityTypes.Add(reader.GetString(0));
             }

             return activityTypes;
         }*/

        internal ActivityTypeModel ReadActivityByInstructorID(int instructorID)
        {
            throw new NotImplementedException();
        }
    }
}
