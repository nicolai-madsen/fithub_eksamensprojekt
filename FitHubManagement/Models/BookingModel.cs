using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models
{
    public class BookingModel
    {
        public int BookingId { get; set; }
        public int ActivityId { get; set; }
        public int CustomerId { get; set; }
        public string PersonalNote { get; set; }
    }
}
