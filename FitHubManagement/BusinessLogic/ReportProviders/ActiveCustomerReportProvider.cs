using FitHubManagement.DataLogic.ReportsDL;
using FitHubManagement.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.BusinessLogic.ReportProviders
{
    internal class ActiveCustomerReportProvider
    {
        public List<ActiveCustomerReportModel> GetActiveCustomers()
        {
            var customers = ActiveCustomerReportDL.GetAllActiveCustomer();
            return customers;
        }
    }
}
