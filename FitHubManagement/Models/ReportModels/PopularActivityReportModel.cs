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
        public DateOnly ActivityDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int BookingCount { get; set; } // Antal kommer fra SQL kommando (COUNT), der tæller hvor mange bookinger der eksiterer for hver activity med LEFT JOIN

        public DateTime StartDateTime => ActivityDate.ToDateTime(StartTime);
        public DateTime EndDateTime => ActivityDate.ToDateTime(EndTime);
        public TimeSpan Duration
    }
}
