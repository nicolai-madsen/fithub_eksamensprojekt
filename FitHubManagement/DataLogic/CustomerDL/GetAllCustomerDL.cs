using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace FitHubManagement.DataLogic.CustomerDL
{
    public class GetAllCustomerDL
    {
        public static string connectionString = "Server=localhost;Database=FitHubDB;" +
                                        "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public List<CustomerModel> GetAllCustomer()
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            SqlConnection connection = this.connection();

            string query = $"SELECT * FROM Customer";

            using (SqlCommand command = new SqlCommand(query, connection))
            
            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    
                    CustomerModel customer = new CustomerModel();
                    customer.CustomerId = Convert.ToInt32(reader["CustomerID"]); // Convert.ToString/Int32 crasher hvis feltet er null, potentiel point of optimization
                    customer.MembershipId = Convert.ToInt32(reader["MembershipID"]);
                    customer.FirstName = Convert.ToString(reader["FirstName"]);
                    customer.LastName = Convert.ToString(reader["LastName"]);
                    customer.Email = Convert.ToString(reader["Email"]);
                    customer.Phone = Convert.ToString(reader["Phone"]);
                    customer.Birthday = Convert.ToDateTime(reader["Birthday"]); // This one probably shouldn't be converted to string, keep as DateTime type instead. Just dunno how, lol
                    customer.PersonalNote = Convert.ToString(reader["PersonalNote"]);
                    customer.Inactive = Convert.ToBoolean(reader["Inactive"]);
                    customer.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    string line = $"Medlems ID: {customer.CustomerId}, Medlem Navn: {customer.FirstName} {customer.LastName} Medlems-Type: {customer.MembershipId}, Email:{customer.Email}, Telefon: {customer.Phone}, Fødselsdag: {customer.Birthday} Personlig Note: [{customer.PersonalNote}] Inaktiv: {customer.Inactive} CreatedDate: {customer.CreatedDate}";

                    customerList.Add(customer);
                }
                return customerList;
            }
        }

        public List<CustomerModel> GetIactiveCustomer() // I våres SQL, er 1 = Inactive, mens 0 = Active 
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            SqlConnection connection = this.connection();


            string query = $"SELECT * FROM Customer WHERE Inactive = 1";

            using (SqlCommand command = new SqlCommand(query, connection))

      
            using (SqlDataReader reader = command.ExecuteReader())
            {
               
                while (reader.Read())
                {

                    CustomerModel customer = new CustomerModel();
                    customer.CustomerId = Convert.ToInt32(reader["CustomerID"]); 
                    customer.MembershipId = Convert.ToInt32(reader["MembershipID"]);
                    customer.FirstName = Convert.ToString(reader["FirstName"]);
                    customer.LastName = Convert.ToString(reader["LastName"]);
                    customer.Email = Convert.ToString(reader["Email"]);
                    customer.Phone = Convert.ToString(reader["Phone"]);
                    customer.Birthday = Convert.ToDateTime(reader["Birthday"]); 
                    customer.PersonalNote = Convert.ToString(reader["PersonalNote"]);
                    customer.Inactive = Convert.ToBoolean(reader["Inactive"]);
                    customer.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    string line = $"Medlems ID: {customer.CustomerId}, Medlem Navn: {customer.FirstName} {customer.LastName} Medlems-Type: {customer.MembershipId}, Email:{customer.Email}, Telefon: {customer.Phone}, Fødselsdag: {customer.Birthday} Personlig Note: [{customer.PersonalNote}] Inaktiv: {customer.Inactive} CreatedDate: {customer.CreatedDate}";

                    customerList.Add(customer);
                }
                return customerList;
            }
        }

        public List<CustomerModel> GetActiveCustomer() // I våres SQL, er 1 = Inactive, mens 0 = Active 
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            SqlConnection connection = this.connection();

            string query = $"SELECT * FROM Customer WHERE Inactive = 0";

            using (SqlCommand command = new SqlCommand(query, connection))

            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {

                    CustomerModel customer = new CustomerModel();
                    customer.CustomerId = Convert.ToInt32(reader["CustomerID"]); 
                    customer.MembershipId = Convert.ToInt32(reader["MembershipID"]);
                    customer.FirstName = Convert.ToString(reader["FirstName"]);
                    customer.LastName = Convert.ToString(reader["LastName"]);
                    customer.Email = Convert.ToString(reader["Email"]);
                    customer.Phone = Convert.ToString(reader["Phone"]);
                    customer.Birthday = Convert.ToDateTime(reader["Birthday"]);
                    customer.PersonalNote = Convert.ToString(reader["PersonalNote"]);
                    customer.Inactive = Convert.ToBoolean(reader["Inactive"]);
                    customer.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    string line = $"Medlems ID: {customer.CustomerId}, Medlem Navn: {customer.FirstName} {customer.LastName} Medlems-Type: {customer.MembershipId}, Email:{customer.Email}, Telefon: {customer.Phone}, Fødselsdag: {customer.Birthday} Personlig Note: [{customer.PersonalNote}] Inaktiv: {customer.Inactive} CreatedDate: {customer.CreatedDate}";

                    customerList.Add(customer);
                }
                return customerList;
            }
        }
        #region
        internal SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.");
            return connection;
        }
        #endregion
    }
}


// Tilføj en kolonne med fulde navne til visning
/* dt.Columns.Add("FullName", typeof(string));*/





