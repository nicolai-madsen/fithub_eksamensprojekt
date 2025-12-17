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
            // Hent medlem via DAL
            CustomerModel customer = _customerRepo.GetIndividualCustomer(customerId);

            // Hvis medlem er inaktiv, kan de ikke booke hold
            if (customer.Inactive) return false;

            // Hvis medlem har MembershipId = "1" (Standard)
            if (customer.MembershipId == 1)
            {
                // Find mandag i den uge hvor holdet ligger
                DateTime weekStart = GetStartOfWeek(activityDate).Date;

                // Hent antallet af bookinger fra for medlem. Kald DAL via BLL instans _bookingRepo
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
