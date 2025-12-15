using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.BusinessLogic
{
    internal class ActivityTypeService // Hvorfor må denne ikke være public?
    {
        /// <summary>
        /// 1. Skifter string parametere ud med et helt ActivityTypeModel objekt i stedet. 
        /// 2. Ændre "int id = " til at bruge static metode, ikke en instans af et objekt. 
        /// 3. Tilføjet de nye properties til parametrene i CreateActivityType metoden
        /// 4. 
        /// </summary>
        private readonly ActivityTypeDAL _activityTypeDAL = new ActivityTypeDAL();

        /*
         * Denne del slettes da vi ikke behøver en instans af CreateActivityTypeDL
        public ActivityTypeService(string connectionString)
        {
            _createDL = new CreateActivityTypeDL(connectionString);
        }
        */

        public ActivityTypeModel CreateActivityType(int ActivityTypeId, int InstructorId, string name, string description)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Holdtypenavn må ikke være tomt.");
            // Ved ikke om der er flere ting der skal valideres her. Nok noget med Instructors. 

            var type = new ActivityTypeModel
            {
                ActivityTypeId = ActivityTypeId,
                InstructorId = InstructorId,
                ActivityTypeName = name,
                ActivityTypeDescription = description,
            };

            ActivityTypeDAL dal = new ActivityTypeDAL();
            int id = dal.CreateActivityType(type);
            type.ActivityTypeId = id;
            return type;
        }

        public List<ActivityTypeModel> GetAllActivityType()
        {
            return _activityTypeDAL.GetAllActivityType();
        }

        public string GetCertifiedInstructor(int activityTypeId)
        {
            return _activityTypeDAL.GetCertifiedInstructor(activityTypeId);
        }
    }
}
