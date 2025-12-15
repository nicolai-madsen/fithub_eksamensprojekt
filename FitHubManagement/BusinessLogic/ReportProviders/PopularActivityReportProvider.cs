using FitHubManagement.DataAccess;
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
            ReportsDAL dal = new ReportsDAL();
            var popularActivities = dal.GetPopularActivities();
            return popularActivities;

            /* SKRIVES SÅDAN UDEN "var": 
            ReportsDAL dal = new ReportsDAL();
            List<PopularActivityReportModel> popularActivities = dal.GetPopularActivities();
            return popularActivities;*/
            //Her bliver der bare defineret at det er en "list" efterfulgt af navnet på den i stedet for at c#
            //selv finder ud af det via "var" altså "variabel"
        }
    }
}
