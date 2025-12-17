using FitHubManagement.Models;
using FitHubManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHubManagement.BusinessLogic
{
    internal class BookingService
    {
        private readonly BookingDAL _bookingRepo = new BookingDAL();
        private readonly CustomerDAL _customerRepo = new CustomerDAL();

        public bool CanCustomerBook(int customerId, DateTime activityDate)
        {
            // 1. Hent kunden via DAL
            CustomerModel customer = _customerRepo.GetIndividualCustomer(customerId);

            // 2. Hvis kunden er inaktiv, må de slet ikke booke
            if (customer.Inactive) return false;

            // 3. Hvis kunden har MembershipId for "Standard" (lad os antage det er 1)
            if (customer.MembershipId == 1)
            {
                // Find mandag i den uge hvor holdet ligger
                DateTime weekStart = GetStartOfWeek(activityDate).Date;

                // Hent antallet af eksisterende bookinger fra DAL
                int bookingCount = _bookingRepo.GetBookingCountForCustomer(customerId, weekStart);

                if (bookingCount >= 2)
                {
                    return false;
                }
            }

            return true;
        }
        // Helper Method, gets start of week
        private DateTime GetStartOfWeek(DateTime dt)
        {
            int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
