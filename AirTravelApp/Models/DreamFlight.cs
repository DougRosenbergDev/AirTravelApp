namespace AirTravelApp.Models
{
    public class DreamFlight
    {
        public int Id { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public int BookedFlightId { get; set; }

        public BookedFlight BookedFlight { get; set; }
    }
}
