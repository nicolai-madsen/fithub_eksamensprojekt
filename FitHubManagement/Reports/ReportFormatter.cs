using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHubManagement.Models.ReportModels;

namespace FitHubManagement.Reports
{
    internal class ReportFormatter
    {
        public string FormatActiveCustomers(List<ActiveCustomerReportModel> customers)
        {
            var lines = new List<string>();
            foreach (var customer in customers)
            {
                lines.Add($"{customer.CustomerId}, {customer.FirstName} {customer.LastName}, {customer.MembershipName}, {customer.Email}, Oprettet: [{customer.CreatedDate:dd/MM/yyyy}]");
            }
            return string.Join("\n", lines);
        }

        public string FormatPopularActivities(List<PopularActivityReportModel> popularActivities)
        {
            var lines = new List<string>();
            foreach (var activity in popularActivities)
            {
                lines.Add($"{activity.ActivityName}, afholdes: {activity.StartDateTime: dd/MM/ hh/mm}, antal tilmeldte: {activity.BookingCount}");
            }
            return string.Join("\n", lines);
        }
    }
}
