namespace FitHubManagement.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string Phone { get; set; }
        public int MembershipId { get; set; }
        public string PersonalNote { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Inactive { get; set; } //true = medlem er inaktiv, false = medlem er aktiv
        // Ændret fra Active til Inactive - svarer til databasen
        public string AktivStatus()
        {
            return Inactive ? "Inaktiv" : "Aktiv";
        }

        public override string ToString()
        {
            return $"ID: {CustomerId} Navn: {FirstName} {LastName} Telefon: {Phone} - {(AktivStatus())}";
        }
        //Denne har en "reference"!! i BookingForm  ----------- Den ovenover burde også have en i CustomerForm?
        public string DisplayText => $"{FullName} - {Phone}";
    }
}





