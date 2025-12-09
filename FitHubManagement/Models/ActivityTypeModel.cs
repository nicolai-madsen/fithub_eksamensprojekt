using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models
{

    /// <summary>
    /// Ændringer:
    /// 1. Ændrer Property datatypes fra object til int/string/whatever - Vi laver bare modellen for objektet her. 
    /// 2. internal set; --> private set; - internal set er slet ikke forkert, det er bare lidt mere passende til systemer der er delt op i flere projekter.
    /// 3. Samme for ActivityName -og Desciption
    /// 4. Filen placeret i namespace (mappe): Models
    /// </summary>
    internal class ActivityTypeModel
    {
        public int ActivityTypeId { get; set; }
        public int InstructorId { get; set; }
        public string ActivityTypeName { get; set; }
        public string ActivityTypeDescription { get; set; }
    }
}
