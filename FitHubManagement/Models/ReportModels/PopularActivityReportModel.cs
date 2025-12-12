using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models.ReportModels
{
    internal class PopularActivityReportModel
    {
        public string ActivityName { get; set; }
        public DateTime StartDateTime { get; set; }   // direkte fra DB
        public DateTime EndDateTime { get; set; }     // hvis du ændrer DB til at have EndDateTime
        public int BookingCount { get; set; }         // fra COUNT i SQL

        // Computed property: kun dato
        public DateOnly ActivityDate => DateOnly.FromDateTime(StartDateTime);

        // Computed property: kun starttid
        public TimeOnly StartTime => TimeOnly.FromDateTime(StartDateTime);

        // Computed property: kun sluttid
        public TimeOnly EndTime => TimeOnly.FromDateTime(EndDateTime);

        // Computed property: varighed
        public TimeSpan Duration => EndDateTime - StartDateTime;
    }
}
