namespace AirTravelApp.Models
{
    public class BookedFlight
    {
        public int Id { get; set; }

        public int FlightId { get; set; }

        public virtual Flight Flight { get; set; }

        public int BookedFlightID { get; set; }
        
        public virtual Booking Booking { get; set; }

    }
}
