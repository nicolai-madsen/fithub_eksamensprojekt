using FitHubManagement.DataAccess;
using FitHubManagement.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.BusinessLogic.ReportProviders
{
    // NICOLAI MADSEN - Hele filen
    internal class ActiveCustomerReportProvider
    {
        public List<ActiveCustomerReportModel> GetActiveCustomers()
        {
            ReportsDAL dal = new ReportsDAL();
            var activecustomers = dal.GetAllActiveCustomer();
            return activecustomers;
            
        }
    }
}
