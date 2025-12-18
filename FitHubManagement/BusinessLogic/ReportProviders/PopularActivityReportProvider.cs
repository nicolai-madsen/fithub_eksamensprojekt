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
    internal class PopularActivityReportProvider
    {
        public List<PopularActivityReportModel> GetPopularActivities()
        {
            ReportsDAL dal = new ReportsDAL();
            var popularActivities = dal.GetPopularActivities();
            return popularActivities;
        }
    }
}
