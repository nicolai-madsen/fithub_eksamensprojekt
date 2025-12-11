using FitHubManagement.DataLogic.ActivityDL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHubManagement.Models;

namespace FitHubManagement.BusinessLogic
{
    public class ActivityService
    {
        public ActivityModel CreateActivity(

            int activityTypeId,
            int instructorId,
            DateTime startDateTime,
            string duration,
            string activityLocation,
            int maxParticipants)

        {
            // 1. Validering af hold placering (Location) og antal hold deltagere (MaxParticipants)
            if (maxParticipants <= 0) throw new Exception("Hold deltagere skal være over 0");

            if (maxParticipants > 20) throw new Exception("Hold deltagere skal være 20 eller under");


            if (string.IsNullOrWhiteSpace(activityLocation)) throw new Exception("Oplys hvor holdet afholdes");


            // 2. Lav objekt med Model
            var activity = new ActivityModel
            {
                ActivityTypeId = activityTypeId,
                InstructorId = instructorId,
                StartDateTime = startDateTime,
                Duration = duration,
                ActivityLocation = activityLocation,
                MaxParticipant = maxParticipants
            };

            // Gem i databasen og få ID tilbage
            activity.ActivityId = CreateActivityDL.CreateActivity(activity);

            // 4. Return final object
            return activity;
        }



        internal List<string> GetAllLocations()
        {
            return SelectLocation.GetAllLocations(); // Vis alle locations
        }



   
        }
}
