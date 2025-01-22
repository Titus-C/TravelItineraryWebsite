using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelItineraryWebsite.Configuration.Entities;
using TravelItineraryWebsite.Data;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Data
{
    public class TravelItineraryWebsiteContext(DbContextOptions<TravelItineraryWebsiteContext> options) : IdentityDbContext<TravelItineraryWebsiteUser>(options)
    {
        public DbSet<TravelItineraryWebsite.Domain.User> User { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Itinerary> Itinerary { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.ItineraryDetail> ItineraryDetail { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
        }
        public DbSet<TravelItineraryWebsite.Domain.Accomodation> Accomodation { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Activity> Activity { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Destination> Destination { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Location> Location { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Transport> Transport { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Weather> Weather { get; set; } = default!;
    }
}
