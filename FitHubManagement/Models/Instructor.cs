using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models
{
    public class Instructor  //Her skal det være public, så får vi adgang til andre klasser.
    {
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Certifications { get; set; } 
    }
}
