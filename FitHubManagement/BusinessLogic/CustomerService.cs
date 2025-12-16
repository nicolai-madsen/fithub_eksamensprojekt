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

        
        public void CreateCustomerBLL(CustomerModel customer)  // Har brugt Per sin Winformsapp19 kode som skabelion
        {


            if (string.IsNullOrWhiteSpace(customer.FirstName) ||
                string.IsNullOrWhiteSpace(customer.LastName) ||
                string.IsNullOrWhiteSpace(customer.Email) ||
                string.IsNullOrWhiteSpace(customer.Phone))

                throw new Exception ();

            if (customer.MembershipId != 1 && customer.MembershipId != 2 && customer.MembershipId != 3)

                throw new Exception();


            if (customer.Birthday.Date == DateTime.Now.Date)

                throw new Exception ();


            repo.CreateCustomer(customer);
        }  

        public void LoadCustomerBLL(CustomerModel customer)
        {

        }

       

        
     
    }
}
