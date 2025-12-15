using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.InstructorDL
{
    public class DeleteInstructorDL
    {/*
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                      "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        
        public static void DeleteInstructor(int instructorId)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.");

            // Remove instructor from database
            string deleteSql = "DELETE FROM Instructor WHERE InstructorID = @instructorId";
            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
            {
                deleteCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int deleted = deleteCmd.ExecuteNonQuery();
                Console.WriteLine($"{deleted} rows deleted.");
            }
        }*/
    }
}

      