using Microsoft.EntityFrameworkCore;
using AirTravelApp.Models;

namespace AirTravelApp.Data
{
    public class FlightDbContext : DbContext
    {
        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(options)
        {

        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<BookedFlight> BookedFlights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
    }
}
