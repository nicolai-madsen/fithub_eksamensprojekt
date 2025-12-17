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
    public class CustomerDAL
    {


        //CREATE

        #region
        public void CreateCustomer(CustomerModel customer)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();
            {
                string insertSql = $"INSERT INTO Customer (MembershipID, FirstName, LastName, Email, Phone, Birthday, PersonalNote) VALUES (@MembershipID, @FirstName, @LastName, @Email, @Phone, @Birthday, @PersonalNote)";
                Console.WriteLine($"SQL Command: {insertSql}");
                using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
                {
                    insertCmd.Parameters.AddWithValue("@MembershipID", customer.MembershipId);
                    insertCmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    insertCmd.Parameters.AddWithValue("@LastName", customer.LastName);
                    insertCmd.Parameters.AddWithValue("@Email", customer.Email);
                    insertCmd.Parameters.AddWithValue("@Phone", customer.Phone);
                    insertCmd.Parameters.AddWithValue("@Birthday", customer.Birthday);
                    insertCmd.Parameters.AddWithValue("@PersonalNote", customer.PersonalNote);


                    int changed = insertCmd.ExecuteNonQuery(); // Tæller mængden af rows der blev ændret af Sql kommando
                    Console.WriteLine($"Created {changed} new Customer.");
                }
            }


        }

        #endregion

        //UPDATE

        public void UpdateCustomer(CustomerModel customer)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            {
                string query = @"UPDATE Customer
                                SET FirstName = @FirstName,
                                LastName = @LastName,
                                Email = @Email,
                                Phone = @Phone,
                                PersonalNote = @PersonalNote,
                                MembershipID = @MembershipID
                                WHERE CustomerID = @CustomerID";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerId);
                cmd.Parameters.AddWithValue("@PersonalNote", customer.PersonalNote);
                cmd.Parameters.AddWithValue("@MembershipID", customer.MembershipId);

                cmd.ExecuteNonQuery();
            }
        }

        #region         

              public void ChangeCustomerActiveStatus(CustomerModel customer, bool newValue)
              {
                  using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                  connection.Open();
                  {
                      string updateSql = $"UPDATE Customer SET IsActive = @newValue WHERE CustomerID = @customerId";
                      using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
                      {
                          updateCmd.Parameters.AddWithValue("@newValue", newValue);
                          updateCmd.Parameters.AddWithValue("@customerId", customer.CustomerId);

                          int updated = updateCmd.ExecuteNonQuery();
                      }
                      
                  }
              }

        #endregion


        //READ

        #region
        public List<CustomerModel> GetAllCustomer()
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();
            {
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

                        customerList.Add(customer);
                    }
                }
                return customerList;
            }
        }

        public List<CustomerModel> GetInactiveCustomer() 
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();
            {

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

                        customerList.Add(customer);
                    }
                }
                return customerList;
            }
            return null;
        }

        public List<CustomerModel> GetActiveCustomer() // I våres SQL, er 1 = Inactive, mens 0 = Active 
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();
            {
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


                        customerList.Add(customer);
                    }
                }
                return customerList;
            }
        }
            
        public CustomerModel GetSingleCustomer(string IdCustomer) //For filtrering, slik at kunde kan finnes via telefon
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string query = $"SELECT CustomerID, MembershipID, FirstName, LastName, Email, Phone, Birthday, PersonalNote,Inactive FROM Customer WHERE CustomerID = @customerId";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@customerId", IdCustomer);
                using (SqlDataReader reader = command.ExecuteReader())  
                {
                    if (reader.Read())
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
                        return customer;

                    }
                }
                return null;
            }
        }

        #endregion

    }
}


                


