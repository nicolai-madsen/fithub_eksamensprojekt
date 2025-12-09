using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.InstructorDL
{
    public class GetAllInstructorDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public static Instructor ReadInstructor(int instructorId)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.");

            // Read instructor from database
            string selectSql = "SELECT InstructorID, FirstName, LastName, Email, Phone, Certifications " +
                       "FROM Instructor WHERE InstructorID = @instructorId";
            using (SqlCommand selectCmd = new SqlCommand(selectSql, connection))
            {
                selectCmd.Parameters.AddWithValue("@instructorId", instructorId);

                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        Instructor ins = new Instructor
                        {
                            InstructorID = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Email = reader.GetString(3),
                            PhoneNumber = reader.GetString(4),
                            Certifications = reader.IsDBNull(5) ? "" : reader.GetString(5)
                        };

                        Console.WriteLine("Instructor found.");
                        return ins;
                    }
                    else
                    {
                        Console.WriteLine("No instructor found.");
                        return null;
                    }
                }
            }
        }
    }
}
