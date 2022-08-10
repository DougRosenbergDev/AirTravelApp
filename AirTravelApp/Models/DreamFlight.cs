namespace AirTravelApp.Models
{
    public class DreamFlight
    {
        public int Id { get; set; }

        public int PassengerId { get; set; }

        public virtual Passenger Passenger { get; set; }

        public int BookedFlightId { get; set; }

        public virtual Booking BookedFlight { get; set; }
    }
}
