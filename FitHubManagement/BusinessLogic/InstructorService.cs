using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using FitHubManagement.Models.FilterModels;

namespace FitHubManagement.BusinessLogic
{
    public class InstructorService
    {
        private InstructorDAL _dal;

        public InstructorService()
        {
            _dal = new InstructorDAL();
        }

        public void SaveInstructor(InstructorModel instructor)
        {
            // Her kan du tilføje validering
            if (string.IsNullOrWhiteSpace(instructor.FirstName))
                throw new ArgumentException("Fornavn må ikke være tomt");

            _dal.UpdateInstructor(instructor);
        }

        /*public List<ActivityFilterModel> GetFilteredActivitiesByInstructor(int? instructorID, DateOnly? activityDate) //Liste med filtrering instrucor + datetime
        {
            return InstructorDAL.GetActivitiesByInstructorAndDate(instructorID, activityDate);
        }*/ //Er ens med metoden nedenunder.
        public List<ActivityFilterModel> GetFilteredActivities(int? instructorID, DateOnly? activityDate)
        {
            {
                return InstructorDAL.GetActivitiesByInstructorAndDate(instructorID, activityDate); // Kald DAL-laget
            }
        }
       
        public List<BookingModel> GetBookingsByActivityID(int activityId)
        {
            return BookingDAL.GetBookingsByActivityID(activityId);
        }

    }
    public class ActivityTypeBLL 
    {
        private ActivityTypeDAL _dal;
        public ActivityTypeBLL()
        {
            _dal = new ActivityTypeDAL();
        }

        public ActivityTypeModel GetActivityByInstructorID(int instructorID)
        {
            return _dal.ReadActivityByInstructorID(instructorID);
        }


    }
    public class CreateNewInstructorWithActivityBLL
    {
        private InstructorDAL _dal = new InstructorDAL();

        public void CreateInstructorWithActivity(
            string firstName,
            string lastName,
            string email,
            string phone,
            string activityName,
            string activityDescription)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(activityName))
            {
                throw new ArgumentException("Alle felter skal udfyldes.");
            }

            // Send videre til DAL
            _dal.CreateInstructorWithActivity(firstName, lastName, email, phone, activityName, activityDescription);
        }
    }
    public class LoadInstructor
    {
        private InstructorDAL _dal = new InstructorDAL();

        public List<InstructorModel> Instructors()
        {
            return _dal.ReadAllInstructors();
        }

        
    }



}

