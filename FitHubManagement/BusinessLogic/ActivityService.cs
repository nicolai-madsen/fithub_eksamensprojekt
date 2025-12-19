using FitHubManagement.DataAccess;
using FitHubManagement.Models;

namespace FitHubManagement.BusinessLogic
{
    // MONA ActivityService.cs
    public class ActivityService
    {
        private readonly ActivityDAL _activityDAL = new ActivityDAL();
        private readonly ActivityTypeDAL _activityTypeDAL = new ActivityTypeDAL();

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
            var match = System.Text.RegularExpressions.Regex.Match(duration, @"\d+");
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
            activity.ActivityId = _activityDAL.CreateActivity(activity);

            return activity;
        }

        public List<string> GetAllLocations()
        {
            return _activityDAL.GetAllLocations();
        }

        // Kommer fra ActivityType 
        public List<ActivityTypeModel> GetAllActivityTypes()
        {
            return _activityTypeDAL.GetAllActivityTypes();
        }

        public List<string> GetAllDuration()
        {
            return _activityDAL.GetAllDuration();
        }

        public List<string> GetAllActivityTypeNames() 
        {
            return _activityDAL.GetAllActivityTypeNames();
        }

        public DateTime GetActivityDate(int activityId)
        {
            return _activityDAL.GetActivityDate(activityId);
        }
    }
}

