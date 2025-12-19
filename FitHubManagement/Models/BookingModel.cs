namespace FitHubManagement.Models
{
    // LENAS KODE
    public class BookingModel
    {
        public int BookingId { get; set; }
        public int ActivityId { get; set; }
        public int CustomerId { get; set; }
        public string PersonalNote { get; set; }
        public string FullName { get; set; }

        // DisplayInfo til at vise i ListBox - ID, Navn og Note
        public string DisplayInfo => $"ID: {BookingId} - {FullName} - Note: {(string.IsNullOrEmpty(PersonalNote) ? "Ingen note" : PersonalNote)}";
    }
}
