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
        private readonly BookingDAL _bookingDAL = new BookingDAL();
        private readonly CustomerDAL _customerDAL = new CustomerDAL();
        private readonly ActivityDAL _activityDAL = new ActivityDAL();

        public void CreateBooking(int activityId, int customerId, string note)
        {




            BookingModel newBooking = new BookingModel
            {
                ActivityId = activityId,
                CustomerId = customerId,
                PersonalNote = note,
            };



            _bookingDAL.CreateBooking(newBooking);
        }

        public bool CanCustomerBook(int customerId, DateTime activityDate)
        {
            // Hent medlem via DAL
            CustomerModel customer = _customerDAL.GetIndividualCustomer(customerId);

            // Hvis medlem er inaktiv, kan de ikke booke hold
            if (customer.Inactive) return false;

            // Hvis medlem har MembershipId = "1" (Standard)
            if (customer.MembershipId == 1)
            {
                // Find mandag i den uge hvor holdet ligger
                DateTime weekStart = GetStartOfWeek(activityDate).Date;

                // Hent antallet af bookinger fra for medlem. Kald DAL via BLL instans _bookingRepo
                int bookingCount = _bookingDAL.GetBookingCountForCustomer(customerId, weekStart);

                if (bookingCount >= 2)
                {
                    return false;
                }
            }

            return true;
        }

        public int GetAvailableSpots(int activityId)
        {
            return _bookingDAL.GetAvailableSpots(activityId);
        }

        // Helper Method, gets start of week, for weekly booking restrictions on "Standard" membership
        private DateTime GetStartOfWeek(DateTime date)
        {
            return date.DayOfWeek switch
            {
                DayOfWeek.Monday => date.Date,
                DayOfWeek.Tuesday => date.AddDays(-1).Date,
                DayOfWeek.Wednesday => date.AddDays(-2).Date,
                DayOfWeek.Thursday => date.AddDays(-3).Date,
                DayOfWeek.Friday => date.AddDays(-4).Date,
                DayOfWeek.Saturday => date.AddDays(-5).Date,
                DayOfWeek.Sunday => date.AddDays(-6).Date,
                _ => date.Date
            };
        }

        private readonly BookingDAL b_bookingDAL = new BookingDAL();

        public List<BookingModel> GetCustomerBooking(int customerId)
        {
            return b_bookingDAL.GetCustomerBooking(customerId);
        }
        public List<BookingModel> GetBookingsByActivityID(int activityId) //Bruges i CreateInstrictorForm som et led til at vise holdtilmeldinger
        {
            return BookingDAL.GetBookingsByActivityID(activityId);
        }
    }
}

