using FitHubManagement.DataAccess;
using FitHubManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.BusinessLogic
{
    public class BookingService

    {
        private readonly BookingDAL _bookingDAL = new BookingDAL();

        public List<BookingModel> GetCustomerBooking(int customerId)
        {
            return _bookingDAL.GetCustomerBooking(customerId);
        }
    }
}
