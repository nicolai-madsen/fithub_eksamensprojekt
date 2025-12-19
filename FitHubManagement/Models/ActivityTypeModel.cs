namespace FitHubManagement.Models
{
    // THEVANAYAKI
    public class ActivityTypeModel
    {
        public int ActivityTypeId { get; set; }
        public int InstructorId { get; set; }
        public string ActivityTypeName { get; set; }
        public string ActivityTypeDescription { get; set; }

        public override string ToString()
        {
            return ActivityTypeName;
        }



    }
}
