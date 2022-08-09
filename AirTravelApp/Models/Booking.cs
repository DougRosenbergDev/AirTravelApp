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
        public virtual ICollection<Flight> Flights { get; set; }

        public virtual ICollection<Passenger> Purchasers { get; set; }
        public virtual ICollection<Passenger> Dreams { get; set; }
    }
}
