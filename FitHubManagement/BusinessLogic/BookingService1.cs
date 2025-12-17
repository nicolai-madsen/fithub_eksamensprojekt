using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.BusinessLogic
{
    internal class BookingService1
    {
        
        public List<BookingModel> GetBookingsByActivityID(int activityId) //Bruges i CreateInstrictorForm som et led til at vise holdtilmeldinger
        {
            return BookingDAL.GetBookingsByActivityID(activityId);
        }
    }
}
