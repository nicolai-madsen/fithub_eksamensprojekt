using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models.ReportModels
{
    // NICOLAI MADSEN - Hele filen
    internal class ActiveCustomerReportModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MembershipName { get; set; }
        public string Email { get; set; }
        public DateOnly CreatedDate { get; set; }

    }
}
