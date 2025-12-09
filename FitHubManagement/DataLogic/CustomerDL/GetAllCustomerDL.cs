using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.DataLogic.CustomerDL
{
    public class GetAllCustomerDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public static List<CustomerModel> GetAllCustomer()
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            Console.WriteLine("Connection to database established.");

            string query = $"SELECT * FROM Customer";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Flyttes op i BLL, mayhaps?
                List<CustomerModel> customerList = new List<CustomerModel>(); // CHANGE THIS TO List<Customer> instead of string, when classes are in place
                while (reader.Read())
                {
                    CustomerModel customer = new CustomerModel();
                    int customerId = Convert.ToInt32(reader["CustomerID"]); // Convert.ToString/Int32 crasher hvis feltet er null, potentiel point of optimization
                    int membershipId = Convert.ToInt32(reader["MembershipID"]);
                    string firstName = Convert.ToString(reader["FirstName"]);
                    string lastName = Convert.ToString(reader["LastName"]);
                    string email = Convert.ToString(reader["Email"]);
                    string? phone = Convert.ToString(reader["Phone"]);
                    string? birthday = Convert.ToString(reader["Birthday"]); // This one probably shouldn't be converted to string, keep as DateTime type instead. Just dunno how, lol
                    string? personalNote = Convert.ToString(reader["PersonalNote"]);
                    bool inActive = Convert.ToBoolean(reader["Inactive"]);
                    string? createdDate = Convert.ToString(reader["CreatedDate"]);

                    string line = $"Medlems ID: {customerId}, Medlem Navn: {firstName} {lastName} Medlems-Type: {membershipId}, Email:{email}, Telefon: {phone}, Fødselsdag: {birthday} Personlig Note: [{personalNote}] Inaktiv: {inActive} CreatedDate: {createdDate}";

                    customerList.Add(customer);
                }
                return customerList;

      
            }

        }

    }
}        
          
    // Tilføj en kolonne med fulde navne til visning
   /* dt.Columns.Add("FullName", typeof(string));*/
 




