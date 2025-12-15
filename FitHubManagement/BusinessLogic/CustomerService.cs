using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHubManagement.Models;
using FitHubManagement.DataAccess;

namespace FitHubManagement.BusinessLogic
{
 
    public class CustomerService
    {
        private readonly CustomerDAL repo = new(); //Repo refererer til DAL

        //Create customer :))) 
        public void CreateCustomerBLL(CustomerModel customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FirstName) ||
                string.IsNullOrWhiteSpace(customer.LastName) ||
                string.IsNullOrWhiteSpace(customer.Email) ||
                string.IsNullOrWhiteSpace(customer.Phone))



                throw new Exception ("Indtast alle krevde felt");

            repo.CreateCustomer(customer); 
        }  

    }
}
