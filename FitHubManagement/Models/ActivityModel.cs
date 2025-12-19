namespace FitHubManagement.Models
{
    public class ActivityModel
    {
        public int ActivityId { get; set; }
        public int ActivityTypeId { get; set; } 
        public string ActivityTypeName { get; set; }
        public int InstructorId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string  Duration { get; set; }
        public string ActivityLocation { get; set; }


        public int MaxParticipant { get; set; }

        public int MaxParticipants { get; set; } //Jeg ved godt, at disse to refererer til det samme, rename i metoder og slet den ene

        // Cake is good. Cake is great. 
        public string DisplayInfo => $"{ActivityTypeName} - {StartDateTime:dd/MM/yyyy} kl. {StartDateTime:hh\\:mm} - {ActivityLocation}";


    }
}
