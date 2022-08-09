namespace AirTravelApp.Models
{
    public class BookedFlightFlight
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int BookedFlightID { get; set; }
        public BookedFlight BookedFlight { get; set; }
    }
}
