using FitHubManagement.Models;
using Microsoft.Data.SqlClient;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    public class CustomerDAL
    {
        #region CREATE METHOD
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

        #region READ 1 CUSTOMER
        public CustomerModel GetIndividualCustomer(int customerId)
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();


            // Read instructor from database
            string selectSql = "SELECT CustomerID, FirstName, LastName, Email, Phone, MembershipID, PersonalNote, Birthday, CreatedDate, Inactive" +
                       " FROM Customer WHERE CustomerID = @CustomerId";
            using (SqlCommand selectCmd = new SqlCommand(selectSql, connection))
            {
                selectCmd.Parameters.AddWithValue("@CustomerId", customerId);
                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CustomerModel customer = new CustomerModel
                        {
                            CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerId")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader.GetString(reader.GetOrdinal("Phone")),
                            MembershipId = reader.GetInt32(reader.GetOrdinal("MembershipId")),
                            PersonalNote = reader.IsDBNull(reader.GetOrdinal("PersonalNote")) ? null : reader.GetString(reader.GetOrdinal("PersonalNote")),
                            Birthday = reader.GetDateTime(reader.GetOrdinal("Birthday")),
                            CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate")),
                            Inactive = reader.GetBoolean(reader.GetOrdinal("Inactive"))

                        };
                        return customer;
                    }
                    return null;
                }
                
            }
        }
        #endregion

        #region UPDATE METHOD
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
        #endregion

        #region READ METHODS     

              public void ChangeCustomerActiveStatus(int customerId, bool Inactive)
              {
                  using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
                  connection.Open();
                  {
                      string updateSql = $"UPDATE Customer SET Inactive = @Inactive WHERE CustomerID = @customerId";
                      using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
                      {
                          updateCmd.Parameters.AddWithValue("@Inactive", Inactive);
                          updateCmd.Parameters.AddWithValue("@customerId", customerId);

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
            
        public CustomerModel GetSingleCustomer() //For filtrering, slik at kunde kan finnes via telefon
        {
            using SqlConnection connection = new SqlConnection(DatabaseConfig.ConnectionString);
            connection.Open();

            string query = $"SELECT CustomerID, MembershipID, FirstName, LastName, Email, Phone, Birthday, PersonalNote,Inactive FROM Customer WHERE CustomerID = @customerId";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
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


                


