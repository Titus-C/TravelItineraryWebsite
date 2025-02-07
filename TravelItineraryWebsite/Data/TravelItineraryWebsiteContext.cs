using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelItineraryWebsite.Configuration.Entities;
using TravelItineraryWebsite.Data;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Data
{
    public class TravelItineraryWebsiteContext(DbContextOptions<TravelItineraryWebsiteContext> options) : IdentityDbContext<TravelItineraryWebsiteUser>(options)
    {
        //public DbSet<TravelItineraryWebsite.Domain.User> User { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Itinerary> Itinerary { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.ItineraryDetail> ItineraryDetail { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Location> Location { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Accommodation> Accommodation { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Activity> Activity { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Transport> Transport { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.DetailList> DetailList { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Day> Day { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transport>(entity => {

                // Relationship to ArrivalLocation
                entity.HasOne(e => e.ArrivalLocation)
                      .WithMany()
                      .HasForeignKey(e => e.ArrivalLocationId)
                      .OnDelete(DeleteBehavior.Cascade);

                // Relationship to DepartureLocation 
                entity.HasOne(e => e.DepartureLocation)
                      .WithMany()
                      .HasForeignKey(e => e.DepartureLocationId)
                      .OnDelete(DeleteBehavior.NoAction); // Changed from Cascade to NoAction
            });

            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
