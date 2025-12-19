namespace FitHubManagement.Models
{
    public class InstructorModel  //Her skal det være public, så får vi adgang til andre klasser.
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Certifications { get; set; }
        

    }
}

