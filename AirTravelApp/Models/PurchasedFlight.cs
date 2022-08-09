namespace AirTravelApp.Models
{
    public class PurchasedFlight
    {
        public int Id { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public int BookedFlightId { get; set; }

        public Booking BookedFlight { get; set; }
    }
}
