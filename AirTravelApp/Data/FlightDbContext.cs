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
        public DbSet<Booking> BookedFlights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        // join entities could be in a separate folder (BookedFlight, DreamFlight, PurchasedFlight)

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BookedFlight>()
                // => big arrow is a Lambda function (anonymous)
                // represents the entity that is being passed in
                .HasKey(bf => bf.Id);

            builder.Entity<BookedFlight>()
                .HasOne(bf => bf.Booking)
                .WithMany(p => p.Flights)
                .HasForeignKey(bf => bf.FlightId);
                
        }
    }
}
