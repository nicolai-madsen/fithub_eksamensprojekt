using FitHubManagement.Models;
using FitHubManagement.DataAccess;
using Microsoft.Data.SqlClient;
using FitHubManagement.Models.FilterModels;

namespace FitHubManagement.BusinessLogic
{
    // LENAS KODE
    public class BookingService
    {
        private readonly BookingDAL _bookingDAL = new BookingDAL();
        private readonly CustomerDAL _customerDAL = new CustomerDAL();
        private readonly ActivityDAL _activityDAL = new ActivityDAL();

        public int CreateBooking(int activityId, int customerId, string note)
        {
            // Validering til "plads på holdet"
            int availableSpots = _bookingDAL.GetAvailableSpots(activityId);
            if (availableSpots <= 0)
            {
                throw new Exception("Der er ikke flere ledige pladser på holdet.");
            }

            // Validering til ugenlige booking begrænsninger for "Standard" medlemmer
            DateTime activityDate = _activityDAL.GetActivityDate(activityId);
            if (!CanCustomerBook(customerId, activityDate))
            {
                throw new Exception("Medlemmet er allerede tilmeldt 2 hold i denne uge.");
            }

            BookingModel newBooking = new BookingModel
            {
                ActivityId = activityId,
                CustomerId = customerId,
                PersonalNote = note,
            };

            try
            {
                // Kald DAL og gem i databasen
                _bookingDAL.CreateBooking(newBooking);

                // Tæl deltagere
                int participantsCount = _bookingDAL.GetAllBookings()
                                                   .Count(b => b.ActivityId == activityId);

                return participantsCount;
            }
            catch (SqlException)
            {
                // Fanges hvis der er dobbeltbookinger på et hold
                throw new Exception("Medlemmet er allerede tilmeldt dette hold.");
            }
        }

        public bool CanCustomerBook(int customerId, DateTime activityDate)
        {
            // Hent medlem via DAL
            CustomerModel customer = _customerDAL.GetIndividualCustomer(customerId);

            // Hvis medlem er inaktiv, kan de ikke bookes på hold
            if (customer.Inactive) return false;

            // Hvis medlem har MembershipId = "1" (Standard)
            if (customer.MembershipId == 1)
            {
                // Find mandag i den uge hvor holdet ligger. Bruger "Helper Method" til beregning
                DateTime weekStart = GetStartOfWeek(activityDate).Date;

                // Hent antallet af bookinger fra for medlem. Kald DAL via BLL instans: _bookingRepo
                int bookingCount = _bookingDAL.GetBookingCountForCustomer(customerId, weekStart);

                if (bookingCount >= 2)
                {
                    return false;
                }
            }

            return true;
        }

        public int GetParticipantCount(int activityId)
        {
            // Kald DAL
            return _bookingDAL.GetAllBookings()
                                     .Where(b => b.ActivityId == activityId)
                                     .Count();
        }


        public List<ActivityFilterModel> GetFilteredActivities(DateOnly? date, string? activityTypeName)
        {
            // BLL opbygger filter-model
            ActivityFilterModel filter = new ActivityFilterModel
            {
                ActivityDate = date,
                ActivityTypeName = activityTypeName
            };

            // BLL kalder DAL
            return _activityDAL.GetFilteredActivities(filter);
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
        public List<BookingModel> GetCustomerBooking(int customerId)
        {
            return _bookingDAL.GetCustomerBooking(customerId);
        }

        private readonly BookingDAL b_bookingDAL = new BookingDAL();

        public List<ViewBookingModel> GetSpecificCustomerBookings(int customerId)
        {
            return _bookingDAL.GetSpecificCustomerBookings(customerId);
        }

        public List<BookingModel> GetBookingsByActivityID(int activityId) //Bruges i CreateInstrictorForm som et led til at vise holdtilmeldinger
        {
            return BookingDAL.GetBookingsByActivityID(activityId);
        }


    }
}

