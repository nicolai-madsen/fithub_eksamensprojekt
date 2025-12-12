using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models
{
    public class MembershipModel
    {
        public int MembershipId { get; set; }
        public string MembershipName { get; set; }
        public string MembershipDescription { get; set; }
        public decimal MonthlyPrice { get; set; }

            
    }
}
