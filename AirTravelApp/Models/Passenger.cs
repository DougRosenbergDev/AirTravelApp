namespace AirTravelApp.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }

        // Navigation Properties
        public virtual ICollection<BookedFlight> BookedFlights { get; set; }
    }
}
