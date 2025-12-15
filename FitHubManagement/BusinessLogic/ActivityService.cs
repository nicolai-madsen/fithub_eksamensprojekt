using FitHubManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHubManagement.Models;
using FitHubManagement.DataAccess;

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
            activity.ActivityId = ActivityDAL.CreateActivity(activity);

            // 4. Return final object
            return activity;
        }



        public List<string> GetAllLocations()
        {
            return ActivityDAL.GetAllLocations(); // Vis alle locations
        }

        public List<string> GetAllActivityTypes()
        {
            return ActivityDAL.GetAllActivityTypes(); //Vis alle typer af holdnavne

        }

        public List<string> GetAllDuration()
        { 
            return ActivityDAL.GetAllDuration(); //Viser alle durations
        }
    }
}
