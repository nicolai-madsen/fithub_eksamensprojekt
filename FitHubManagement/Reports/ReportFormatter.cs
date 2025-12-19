using FitHubManagement.Models.ReportModels;

namespace FitHubManagement.Reports
{
    // NICOLAI MADSEN - Hele filen
    internal class ReportFormatter
    {
        public string FormatActiveCustomers(List<ActiveCustomerReportModel> customers)
        {
            var lines = new List<string>();
            foreach (var customer in customers)
            {
                lines.Add($"{customer.FirstName} {customer.LastName}  |  {customer.MembershipName}  |  {customer.Email}  |  Oprettet: [{customer.CreatedDate:dd/MM/yyyy}]\n");
            }
            return string.Join("\n", lines);
        }

        public string FormatPopularActivities(List<PopularActivityReportModel> popularActivities)
        {
            var lines = new List<string>();
            foreach (var activity in popularActivities)
            {
                lines.Add($"{activity.ActivityName}  |  Antal tilmeldte: {activity.BookingCount}  |  Afholdes: {activity.StartDateTime: dd/MM/ hh/mm}\n");
            }
            return string.Join("\n", lines);
        }
    }
}
