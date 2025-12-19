using FitHubManagement.Models;
using FitHubManagement.Models.FilterModels;
using Microsoft.Data.SqlClient;
using System.Data;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    internal class InstructorDAL
    {
        public void UpdateInstructor(InstructorModel instructor)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            {
                string query = @"UPDATE Instructor
                             SET FirstName = @FirstName,
                                 LastName = @LastName,
                                 Email = @Email,
                                 Phone = @Phone
                             WHERE InstructorID = @InstructorID";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FirstName", instructor.FirstName);
                cmd.Parameters.AddWithValue("@LastName", instructor.LastName);
                cmd.Parameters.AddWithValue("@Email", instructor.Email);
                cmd.Parameters.AddWithValue("@Phone", instructor.PhoneNumber);
                cmd.Parameters.AddWithValue("@InstructorID", instructor.InstructorId);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteInstructor(int instructorId)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            // Remove instructor from database
            string deleteSql = "DELETE FROM Instructor WHERE InstructorID = @instructorId";
            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
            {
                deleteCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int deleted = deleteCmd.ExecuteNonQuery();
                Console.WriteLine($"{deleted} rows deleted.");
            }
        }


        public List<InstructorModel> ReadAllInstructors()
        {
            List<InstructorModel> instructors = new List<InstructorModel>();

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            string selectSql = "SELECT InstructorID, FirstName, LastName, Email, Phone FROM Instructor"; //HER SKAL DER OGSÅ VÆRE CERTIFICATIONS
            using SqlCommand selectCmd = new SqlCommand(selectSql, connection);
            using SqlDataReader reader = selectCmd.ExecuteReader();

            while (reader.Read())
            {
                InstructorModel ins = new InstructorModel
                {
                    InstructorId = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    PhoneNumber = reader.GetString(4),
                    // DEN FINDES IKKE I DATABASEN --- Certifications = reader.IsDBNull(5) ? "" : reader.GetString(5)
                };

                instructors.Add(ins);
            }

            return instructors;
        }

        public static List<ActivityFilterModel> GetActivitiesByInstructorAndDate(int? instructorID, DateOnly? activityDate) //Parametre kan være nullable, da det er et søgefilter
        {
            List<ActivityFilterModel> activities = new List<ActivityFilterModel>();

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            // JOIN tabeller for at få alle data. CAST splitter StartDateTime op i dato og tid
            string filterQuery = @"
            SELECT ActivityID,
            CAST(StartDateTime AS DATE) AS ActivityDate,
            CAST(StartDateTime AS TIME) AS StartTime,
            CAST(EndDateTime AS TIME) AS EndTime,
            a.ActivityLocation,
            at.ActivityTypeName,
            i.FirstName + ' ' + i.LastName AS InstructorName
            FROM Activity a
            INNER JOIN ActivityType at ON a.ActivityTypeID = at.ActivityTypeID 
            INNER JOIN Instructor i ON at.InstructorID = i.InstructorID
            WHERE 1=1
             ";

            using SqlCommand command = new SqlCommand(filterQuery, connection);

            // Tilføj InstructorID filter hvis valgt
            if (instructorID.HasValue)
            {
                filterQuery += " AND i.InstructorID = @InstructorID";
                command.Parameters.AddWithValue("@InstructorID", instructorID.Value);
            }

            // Tilføj dato filter
            if (activityDate.HasValue)
            {
                // Hvis dato er valgt, søg på den specifikke dato
                filterQuery += " AND CAST(StartDateTime AS DATE) = @ActivityDate";
                command.Parameters.AddWithValue("@ActivityDate", activityDate.Value.ToDateTime(TimeOnly.MinValue));
            }
            else
            {
                // Hvis ingen dato valgt, søg fra i dag og fremefter
                filterQuery += " AND CAST(StartDateTime AS DATE) >= @TodayDate";
                command.Parameters.AddWithValue("@TodayDate", DateTime.Today);
            }

            

            filterQuery += " ORDER BY StartDateTime"; // Sorter efter dato og tid

            command.CommandText = filterQuery;

            using SqlDataReader reader = command.ExecuteReader();

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
        // Opret ny instructor med ny activitytype ---- Er lavet som "stored procedure" i databasen"
        public void CreateInstructorWithActivity
            (string firstName,
            string lastName,
            string email,
            string phone,
            string activityName,
            string activityDescription)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            using (SqlCommand cmd = new SqlCommand("CreateInstructorWithActivity", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@ActivityTypeName", activityName);
                cmd.Parameters.AddWithValue("@ActivityTypeDescription", activityDescription);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
