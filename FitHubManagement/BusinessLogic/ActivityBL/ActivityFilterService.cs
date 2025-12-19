using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHubManagement.DataAccess;
using FitHubManagement.Models.FilterModels;

namespace FitHubManagement.BusinessLogic.ActivityBL
{
    // NICOLAI
    internal class ActivityFilterService
    {
        private readonly ActivityDAL _filterDL;

        public ActivityFilterService()
        {
            _filterDL = new ActivityDAL();
        }

        public List<ActivityFilterModel> GetFilteredActivities(ActivityFilterModel filterModel) // Kald DAL metode
        {
            var activities = _filterDL.GetFilteredActivities(filterModel);

            return activities;
        }
    }
}
