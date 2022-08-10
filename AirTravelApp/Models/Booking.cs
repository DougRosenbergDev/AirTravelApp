namespace AirTravelApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int ConfirmationNumber { get; set; }
        public int FlightId { get; set; }
        public int PassengerId { get; set; }

        // Not stored property
        public int PassengerCount => Purchasers?.Count ?? 0;
        public int DreamFlightCount => Dreams?.Count ?? 0;

        // Navigation Properties
        public virtual ICollection<BookedFlight> Flights { get; set; }

        public virtual ICollection<PurchasedFlight> Purchasers { get; set; }

        public virtual ICollection<DreamFlight> Dreams { get; set; }
    }
}
