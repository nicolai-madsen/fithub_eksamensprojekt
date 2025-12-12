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
        public int BookingCount { get; set; }         // fra COUNT i SQL

        

    
    }
}
