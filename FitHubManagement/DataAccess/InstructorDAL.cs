using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataAccess
{
    internal class InstructorDAL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public static void CreateInstructor(string firstName, string lastName, string email, string phone, string Certifications) //Metoden
        {
            using SqlConnection connection = new SqlConnection(connectionString); //Åbner connection med "using SqlConnection..."
            connection.Open(); //Åbner forbindelse


            string insertSql = "INSERT INTO Instructor (FirstName, LastName, Email, Phone, Certifications) VALUES (@FirstName, @LastName, @Email, @Phone, @Certifications)"; //
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@FirstName", firstName); //Sæt værdien firstname ind i SQL-parameteren.
                insertCmd.Parameters.AddWithValue("@LastName", lastName);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.Parameters.AddWithValue("@Phone", phone);
                insertCmd.Parameters.AddWithValue("@Certifications", Certifications);



                int changed = insertCmd.ExecuteNonQuery();

            }
        }

        public static void UpdateFirstName(int instructorId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = "UPDATE Instructor SET FirstName = @newValue WHERE InstructorID = @instructorId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateLastName(int instructorId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = "UPDATE Instructor SET LastName = @newValue WHERE InstructorID = @instructorId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdateEmail(int instructorId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = "UPDATE Instructor SET Email = @newValue WHERE InstructorID = @instructorId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }

        public static void UpdatePhone(int instructorId, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Connection to database established.");

            string updateSql = "UPDATE Instructor SET Phone = @newValue WHERE InstructorID = @instructorId";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@instructorId", instructorId);

                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} rows updated.");
            }
        }
        public void UpdateInstructor(InstructorModel instructor)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
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
                cmd.Parameters.AddWithValue("@InstructorID", instructor.InstructorID);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

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
        }

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
