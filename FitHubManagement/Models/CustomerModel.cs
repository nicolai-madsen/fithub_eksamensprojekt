using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string Phone { get; set; }
        public int MembershipId { get; set; }
        public string PersonalNote { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Inactive { get; set; } // true = bruger er aktiv, false betyder at bruger inaktiv.
        // Ændret fra Active til Inactive - svarer til databasen
    }

}

