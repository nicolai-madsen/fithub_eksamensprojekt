using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models
{
    internal class ViewBookingModel
    {
        public class ViewBookingModel
        {
            public int BookingId { get; set; }
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public DateTime StartDateTime { get; set; }
            public string ActivityTypeName { get; set; }

            public string DisplayInfo => $"Aktivitet: {ActivityTypeName} - Instruktør: {Name} - Start: {StartDateTime}";

        }
    }
}
