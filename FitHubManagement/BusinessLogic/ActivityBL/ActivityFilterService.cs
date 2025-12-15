using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHubManagement.DataLogic.ActivityDL;
using FitHubManagement.Models.FilterModels;

namespace FitHubManagement.BusinessLogic.ActivityBL
{
    internal class ActivityFilterService
    {
        private readonly ActivityFilterDL _filterDL;

        public ActivityFilterService()
        {
            _filterDL = new ActivityFilterDL();
        }

        public List<ActivityFilterModel> GetFilteredActivities(ActivityFilterModel filterModel) // Kald DAL metode
        {
            var activities = _filterDL.GetFilteredActivities(filterModel);

            return activities;
        }
    }
}
