using FitHubManagement.DataLogic.InstructorDL;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitHubManagement.DataLogic.ActivityTypeDL.GetAllActivityTypeDL;

namespace FitHubManagement.BusinessLogic
{
    public class InstructorService
    {
        private UpdateInstructorDL _dal;

        public InstructorService()
        {
            _dal = new UpdateInstructorDL();
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
        private ActivityTypeDL _dal;

        public ActivityTypeBLL()
        {
            _dal = new ActivityTypeDL();
        }

        public ActivityTypeModel GetActivityByInstructorID(int instructorID)
        {
            return _dal.ReadActivityByInstructorID(instructorID);
        }

    }
}
