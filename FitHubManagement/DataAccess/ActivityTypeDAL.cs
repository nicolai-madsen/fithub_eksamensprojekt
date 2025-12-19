using FitHubManagement.Models;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    internal class ActivityTypeDAL

    //____________________________________THEVANAYAKI KODE - HELE FILEN________________________________________
    {
        public void CreateActivityType(ActivityTypeModel activityType)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string insertSql = @"INSERT INTO ActivityType (InstructorID, ActivityTypeName, ActivityTypeDescription)
                         VALUES (@InstructorID, @ActivityTypeName, @ActivityTypeDescription)";

            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@InstructorID", activityType.InstructorId);
                insertCmd.Parameters.AddWithValue("@ActivityTypeName", activityType.ActivityTypeName);
                insertCmd.Parameters.AddWithValue("@ActivityTypeDescription", activityType.ActivityTypeDescription);

                insertCmd.ExecuteNonQuery(); // udfør indsættelsen
            }
        }
        //________________________________________________________________________________________________________

        // Metode der henter alle aktiviteter fra databasen
        public List<ActivityTypeModel> GetAllActivityTypes()
        {
            try
            {
                // Liste til at gemme alle Activity-objekter
                List<ActivityTypeModel> activityTypeList = new List<ActivityTypeModel>();


                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();


                string query =
                    "SELECT ActivityTypeID, InstructorID, ActivityTypeName, ActivityTypeDescription FROM ActivityType";


                using SqlCommand command = new SqlCommand(query, connection);

                // Udfører SELECT og får en SqlDataReader
                using SqlDataReader reader = command.ExecuteReader();
                {
                    // Går igennem hver række i resultatet
                    while (reader.Read())
                    {
                        // Håndterer nullable Description (kan være NULL i databasen)
                        int descriptionIndex = reader.GetOrdinal("ActivityTypeDescription");
                        string description = null;
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
                            ActivityTypeDescription = description
                        };

                        // Lægger Activity-objektet i listen
                        activityTypeList.Add(a);
                    }
                }

                // Returnerer listen med alle aktiviteter
                return activityTypeList;
            }
            catch (SqlException ex)
            {
                throw new Exception("Kunne ikke oprette forbindelse til databasen. Kontroller din netværksforbindelse.", ex);
            }
        }


        // Metode der henter en aktivitet baseret på InstructorID
        public ActivityTypeModel ReadActivityByInstructorID(int instructorID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();
                {
                    string query = @"SELECT ActivityTypeId, ActivityTypeName, InstructorID
                                 FROM ActivityType
                                 WHERE InstructorID = @InstructorID";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@InstructorID", instructorID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        ActivityTypeModel activity = new ActivityTypeModel();
                        activity.ActivityTypeId = (int)reader["ActivityTypeId"];
                        activity.ActivityTypeName = reader["ActivityTypeName"].ToString();
                        activity.InstructorId = (int)reader["InstructorID"];
                        return activity;
                    }

                    return null;
                }
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen. Kontroller din netværksforbindelse.", ex);
            }
        }

        //________________________________________________________________________________________________________
        public string GetCertifiedInstructor(int activityTypeId) //Henter certificeret instruktør til relatede holdtype
        {
           try
            {
                using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                connection.Open();

                // query henter First -og LastName fra Instructor via Instructor FK i ActivityType (JOIN)
                string selectSql = @"
                SELECT i.FirstName + ' ' + i.LastName AS CertifiedInstructorName 
                FROM ActivityType at 
                INNER JOIN Instructor i ON at.InstructorID = i.InstructorID
                WHERE at.ActivityTypeID = @ActivityTypeID
                ";

                using (SqlCommand cmd = new SqlCommand(selectSql, connection))
                {
                    cmd.Parameters.AddWithValue("@ActivityTypeID", activityTypeId);

                    var result = cmd.ExecuteScalar();
                    return result.ToString();
                }
            }
            catch (SqlException ex)
            {
                // Log fejlen her hvis nødvendigt
                throw new Exception("Kunne ikke oprette forbindelse til databasen. Kontroller din netværksforbindelse.", ex);
            }
        }


    }
}
