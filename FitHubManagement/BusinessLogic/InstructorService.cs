using FitHubManagement.DataAccess;
using FitHubManagement.Models;
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
}
