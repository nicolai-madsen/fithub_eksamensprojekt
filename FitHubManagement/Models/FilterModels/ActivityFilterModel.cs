using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.Models.FilterModels
{
    public class ActivityFilterModel
    {
        public int ActivityId { get; set; }
        public string? ActivityTypeName { get; set; }
        public string? InstructorName { get; set; }
        public DateOnly? ActivityDate { get; set; }
        public TimeOnly? StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }
        public string? ActivityLocation { get; set; }

        public override string ToString()
        {
            return
       $"Hold: {ActivityTypeName}\n" +
       $"Instruktør: {InstructorName}\n" +
       $"Dato: {ActivityDate:dd/MM/yyyy}\n" +
       $"Tid: {StartTime:HH\\:mm}\n" +
       $"Sted: {ActivityLocation}";
        }
    }
}
