using FitHubManagement.DataAccess;
using FitHubManagement.Models;

namespace FitHubManagement.BusinessLogic
{
    // THEVANAYAKI
    public class ActivityTypeService 
    {
        /// <summary>
        /// 1. Skifter string parametere ud med et helt ActivityTypeModel objekt i stedet. 
        /// 2. Ændre "int id = " til at bruge static metode, ikke en instans af et objekt. 
        /// 3. Tilføjet de nye properties til parametrene i CreateActivityType metoden
        /// 4. 
        /// </summary>
        private readonly ActivityTypeDAL _activityTypeDAL = new ActivityTypeDAL();

        public List<ActivityTypeModel> GetAllActivityTypes()
        {
            return _activityTypeDAL.GetAllActivityTypes();
        }

        public string GetCertifiedInstructor(int activityTypeId)
        {
            return _activityTypeDAL.GetCertifiedInstructor(activityTypeId);
        }
    }
    public class ActivityTypeBLL1
    {
        private readonly ActivityTypeDAL _activityTypeDal = new ActivityTypeDAL();

        public void CreateActivityType(ActivityTypeModel model)
        {
            if (string.IsNullOrWhiteSpace(model.ActivityTypeName))
                throw new ArgumentException("ActivityTypeName må ikke være tomt");

            _activityTypeDal.CreateActivityType(model);
        }
    }
}
