using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using FitHubManagement.Models.FilterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<ActivityFilterModel> GetFilteredActivitiesByInstructor(int? instructorID, DateOnly? activityDate) //Liste med filtrering instrucot + datetime
        {
            return InstructorDAL.GetActivitiesByInstructorAndDate(instructorID, activityDate);
        }

    }
    public class ActivityTypeBLL //Skal denne ikke ligge i InstructorService klassen?
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

}
