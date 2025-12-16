using FitHubManagement.DataAccess;
using FitHubManagement.Models;

namespace FitHubManagement.BusinessLogic
{
    public class ActivityService
    {
        private readonly ActivityDAL _activityDal = new ActivityDAL();
        private readonly ActivityTypeDAL _activityTypeDal = new ActivityTypeDAL();

        public ActivityModel CreateActivity(
            int activityTypeId,
            int instructorId,
            DateTime startDateTime,
            string duration,
            string activityLocation,
            int maxParticipants)
        {
            // 1. Validering
            if (maxParticipants <= 0)
                throw new ArgumentException("Hold deltagere skal være over 0", nameof(maxParticipants));

            if (maxParticipants > 20)
                throw new ArgumentException("Hold deltagere skal være 20 eller under", nameof(maxParticipants));

            if (string.IsNullOrWhiteSpace(activityLocation))
                throw new ArgumentException("Oplys hvor holdet afholdes", nameof(activityLocation));

            // opret variabel til at holde minutter, konverteret og omregnet fra string Duration
            int minutes = 0;
            var match = System.Text.RegularExpressions.Regex.Match(duration, @"\d+"); //  " \d+ " en "regular expression" også kaldt Regex. "\d" betyder "find tal". " + " betyder kig efter flere tal
                                                                                      // "var match" typen er en Match-klasse fra Text.RegularExpressions (derfor bruges "var") 
            if (match.Success)
            {
                minutes = int.Parse(match.Value);
            }
            else
            {
                throw new ArgumentException("Indtastet varighed er ugyldig");
            }

            DateTime endDateTime = startDateTime.AddMinutes(minutes);

                // 2. Model
                var activity = new ActivityModel
                {
                    ActivityTypeId = activityTypeId,
                    InstructorId = instructorId,
                    StartDateTime = startDateTime,
                    EndDateTime = endDateTime,
                    Duration = duration,
                    ActivityLocation = activityLocation,
                    MaxParticipant = maxParticipants
                };

            // 3. DAL-kald (INSTANS!)
            activity.ActivityId = _activityDal.CreateActivity(activity);

            return activity;
        }

        public List<string> GetAllLocations()
        {
            return _activityDal.GetAllLocations();
        }

        // Kommer fra ActivityType 
        public List<ActivityTypeModel> GetAllActivityTypes()
        {
            return _activityTypeDal.GetAllActivityTypes();
        }

        public List<string> GetAllDuration()
        {
            return _activityDal.GetAllDuration();
        }
    }
}

/*using FitHubManagement.DataAccess;
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
*/