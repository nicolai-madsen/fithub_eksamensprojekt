using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.InstructorDL
{
    public class CreateInstructorDL 
    {
        /*
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
               insertCmd.Parameters.AddWithValue("@Certifications",Certifications);



               int changed = insertCmd.ExecuteNonQuery();

           }
       }*/
    }
}
