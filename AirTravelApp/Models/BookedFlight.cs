namespace AirTravelApp.Models
{
    public class BookedFlight
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int BookedFlightID { get; set; }
        public Booking Booking { get; set; }

    }
}
