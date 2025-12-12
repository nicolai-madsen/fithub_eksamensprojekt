using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitHubManagement.DataLogic.ActivityDL
{
    public class SelectLocation
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public static List<string> GetAllLocations()
        {
            using SqlConnection connection = new SqlConnection(connectionString); // "Using" giver adgang til alle de metoder som klassen SqlConnection. 
            connection.Open(); // Åben forbindelsen til databasen
            Console.WriteLine("Connection to database established.\n");


            var activitylocation = new List<string>();

            string selectSql =
            "SELECT DISTINCT ActivityLocation FROM Activity WHERE ActivityLocation IS NOT NULL AND ActivityLocation <> ''";

            Console.WriteLine($"SQL Command: {selectSql}");
            using (SqlCommand insertCmd = new SqlCommand(selectSql, connection))


            using (SqlDataReader reader = insertCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    activitylocation.Add(reader.GetString(0));
                }
            }


            return activitylocation;
        }

        public static List<string> GetAllActivityTypes() //En liste af alle navne på holdtyper. Metoden hører til i ActivityType, men der er ikke oprettet klasser i ActivityType endnu.
        {
            using SqlConnection connection = new SqlConnection(connectionString); // "Using" giver adgang til alle de metoder som klassen SqlConnection. 
            connection.Open(); // Åben forbindelsen til databasen
            Console.WriteLine("Connection to database established.\n");

            var activityTypeNameOnly = new List<string>();

            string selectSql = "SELECT ActivityTypeName FROM ActivityType";

            Console.WriteLine($"SQL Command: {selectSql}");
            using (SqlCommand insertCmd = new SqlCommand(selectSql, connection))

            using (SqlDataReader reader = insertCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    activityTypeNameOnly.Add(reader.GetString(0));

                }
            }
            return activityTypeNameOnly;
        }

    }
}
