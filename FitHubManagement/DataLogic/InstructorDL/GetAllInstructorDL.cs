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
        public static string connectionString = "Server=.;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public static InstructorModel ReadInstructor(int instructorId)
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
                        InstructorModel ins = new InstructorModel
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
        public static List<InstructorModel> ReadAllInstructors()
        {
            List<InstructorModel> instructors = new List<InstructorModel>();

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string selectSql = "SELECT InstructorID, FirstName, LastName, Email, Phone FROM Instructor"; //HER SKAL DER OGSÅ VÆRE CERTIFICATIONS
            using SqlCommand selectCmd = new SqlCommand(selectSql, connection);
            using SqlDataReader reader = selectCmd.ExecuteReader();

            while (reader.Read())
            {
                InstructorModel ins = new InstructorModel
                {
                    InstructorID = reader.GetInt32(0),
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
    }
}
