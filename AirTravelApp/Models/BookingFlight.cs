namespace AirTravelApp.Models
{
    public class BookingFlight
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int BookedFlightID { get; set; }
        public Booking BookedFlight { get; set; }
    }
}
