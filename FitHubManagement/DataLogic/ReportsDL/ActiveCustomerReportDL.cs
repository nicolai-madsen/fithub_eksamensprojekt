using FitHubManagement.Models.ReportModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace FitHubManagement.DataLogic.ReportsDL
{
    internal class ActiveCustomerReportDL
    {
        public static string connectionString = "Data Source=.;Initial Catalog=FitHubDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public static List<ActiveCustomerReportModel> GetAllActiveCustomer()
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            Console.WriteLine("Connection to database established.");

            // Vælg felter fra databasen der skal bruges til at fylde rapport-DTO (ActiveCustomerReportModel.cs)
            // For hver Customer hentes også navnet på deres medlemskab (MembershipName) 
            // via JOIN på Membership, baseret på MembershipID. Giver Customer et MembershipName i stedet for ID.
            // Kun vælg aktive medlemmer (Inactive = 0/False)
            string query = @"
                SELECT 
                       c.CustomerID,
                       c.FirstName,
                       c.LastName,
                       m.MembershipName,
                       c.Email,
                       c.CreatedDate
                FROM Customer c
                JOIN Membership m ON c.MembershipID = m.MembershipID
                WHERE c.Inactive = 0";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {

                List<ActiveCustomerReportModel> activeCustomerList = new List<ActiveCustomerReportModel>();
                while (reader.Read())
                {
                    int customerId = Convert.ToInt32(reader["CustomerID"]);
                    string membershipName = Convert.ToString(reader["MembershipName"]);
                    string firstName = Convert.ToString(reader["FirstName"]);
                    string lastName = Convert.ToString(reader["LastName"]);
                    string email = Convert.ToString(reader["Email"]);

                    DateTime dateTime = (DateTime)reader["CreatedDate"];
                    DateOnly createdDate = DateOnly.FromDateTime(dateTime);

                    ActiveCustomerReportModel inactiveCustomer = new ActiveCustomerReportModel
                    {
                        CustomerId = customerId,
                        FirstName = firstName,
                        LastName = lastName,
                        MembershipName = membershipName,
                        Email = email,
                        CreatedDate = createdDate
                    };
                    activeCustomerList.Add(inactiveCustomer);
                }
                return activeCustomerList;

            }
        }
    }
}
*/