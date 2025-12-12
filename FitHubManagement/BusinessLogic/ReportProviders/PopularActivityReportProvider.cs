using FitHubManagement.DataLogic.ReportsDL;
using FitHubManagement.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.BusinessLogic.ReportProviders
{
    internal class PopularActivityReportProvider
    {
        public List<PopularActivityReportModel> GetPopularActivities()
        {
            var popularActivities = PopularActivityReportDL.GetPopularActivities();
            return popularActivities;
        }
    }
}
