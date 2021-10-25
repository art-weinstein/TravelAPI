using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Destination>()
            .HasData(
              new Destination { DestinationId = 1, Country = "USA", City = "Miami",  Rating = 7},
              new Destination { DestinationId = 2, Country = "Honduras", City = "Roatan",  Rating = 9},
              new Destination { DestinationId = 3, Country = "Spain", City = "Madrid",  Rating = 8},
              new Destination { DestinationId = 4, Country = "England", City = "London",  Rating = 10}
            );
        }
    }
}