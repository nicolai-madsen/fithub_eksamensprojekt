using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models
{
    public class ActivityModel
    {
        public int ActivityId { get; set; }
        public int ActivityTypeId { get; set; } 
        public int InstructorId { get; set; }
        public DateTime StartDateTime { get; set; }
        public string  Duration { get; set; }
        public string ActivityLocation { get; set; }

        public int MaxParticipant { get; set; }

        public int MaxParticipants { get; set; } //Jeg ved godt, at disse to refererer til det samme, rename i metoder og slet den ene
        public string ActivityTypeName { get; internal set; }
        public string ActivityDuration { get; internal set; }
        public DateOnly ActivityDate { get; internal set; }

        // Cake is good. Cake is great. 

    }
}
