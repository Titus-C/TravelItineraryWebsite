//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using TravelItineraryWebsite.Configuration.Entities;
//using TravelItineraryWebsite.Data;
//using TravelItineraryWebsite.Domain;

//namespace TravelItineraryWebsite.Data
//{

//    public class TravelItineraryWebsiteContext(DbContextOptions<TravelItineraryWebsiteContext> options) : IdentityDbContext<TravelItineraryWebsiteUser>(options)
//    {
//        //public DbSet<TravelItineraryWebsite.Domain.User> User { get; set; } = default!;
//        public DbSet<TravelItineraryWebsite.Domain.Itinerary> Itinerary { get; set; } = default!;
//        public DbSet<TravelItineraryWebsite.Domain.ItineraryDetail> ItineraryDetail { get; set; } = default!;
//        public DbSet<TravelItineraryWebsite.Domain.Location> Location { get; set; } = default!;
//        public DbSet<TravelItineraryWebsite.Domain.Accommodation> Accommodation { get; set; } = default!;
//        public DbSet<TravelItineraryWebsite.Domain.Activity> Activity { get; set; } = default!;
//        public DbSet<TravelItineraryWebsite.Domain.Transport> Transport { get; set; } = default!;
//        public DbSet<TravelItineraryWebsite.Domain.DetailList> DetailList { get; set; } = default!;
//        public DbSet<TravelItineraryWebsite.Domain.Day> Day { get; set; } = default!;

//        // Get the IDbContextFactory from the service provider
//        var contextFactory = this.GetService<IDbContextFactory<TravelItineraryWebsiteContext>>();

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            modelBuilder.Entity<Transport>(entity => {

//                // Relationship to ArrivalLocation
//                entity.HasOne(e => e.ArrivalLocation)
//                      .WithMany()
//                      .HasForeignKey(e => e.ArrivalLocationId)
//                      .OnDelete(DeleteBehavior.Cascade);

//                // Relationship to DepartureLocation 
//                entity.HasOne(e => e.DepartureLocation)
//                      .WithMany()
//                      .HasForeignKey(e => e.DepartureLocationId)
//                      .OnDelete(DeleteBehavior.NoAction); // Changed from Cascade to NoAction
//            });

//            modelBuilder.ApplyConfiguration(new RoleSeed());
//            modelBuilder.ApplyConfiguration(new UserSeed());
//            modelBuilder.ApplyConfiguration(new UserRoleSeed());

//            modelBuilder.ApplyConfiguration(new LocationSeed()); // Seed Locations (FIRST)
//            modelBuilder.ApplyConfiguration(new ItinerarySeed()); // Seed Itineraries (SECOND - Creates Days)
//            modelBuilder.ApplyConfiguration(new ActivitySeed()); // Seed Activities (FOURTH)
//            modelBuilder.ApplyConfiguration(new TransportSeed()); // Seed Transports (SIXTH)
//            modelBuilder.ApplyConfiguration(new ItineraryDetailSeed()); // Seed ItineraryDetails (SEVENTH)


//        }
//    }
//}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure; // For IInfrastructure
using Microsoft.Extensions.DependencyInjection; // For IServiceCollection
using TravelItineraryWebsite.Configuration.Entities;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Data
{
    public partial class TravelItineraryWebsiteContext : IdentityDbContext<TravelItineraryWebsiteUser>
    {
        private readonly IDbContextFactory<TravelItineraryWebsiteContext> _contextFactory;

        public TravelItineraryWebsiteContext(DbContextOptions<TravelItineraryWebsiteContext> options, IDbContextFactory<TravelItineraryWebsiteContext> contextFactory)
            : base(options)
        {
            _contextFactory = contextFactory;
        }

        public DbSet<Itinerary> Itinerary { get; set; } = default!;
        public DbSet<ItineraryDetail> ItineraryDetail { get; set; } = default!;
        public DbSet<Location> Location { get; set; } = default!;
        public DbSet<Accommodation> Accommodation { get; set; } = default!;
        public DbSet<Activity> Activity { get; set; } = default!;
        public DbSet<Transport> Transport { get; set; } = default!;
        public DbSet<DetailList> DetailList { get; set; } = default!;
        public DbSet<Day> Day { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transport>(entity =>
            {
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

            // Apply seed configurations (NO contextFactory here for the basic ones)
            modelBuilder.ApplyConfiguration(new LocationSeed());
            modelBuilder.ApplyConfiguration(new ItinerarySeed());
            modelBuilder.ApplyConfiguration(new ActivitySeed());
            modelBuilder.ApplyConfiguration(new TransportSeed());
            modelBuilder.ApplyConfiguration(new AccommodationSeed());


            // Use the injected _contextFactory here to create a context for ItineraryDetailSeed
            using (var context = _contextFactory.CreateDbContext())
            {
                modelBuilder.ApplyConfiguration(new ItineraryDetailSeed(context)); // Pass the context here
            }

            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
        }

        public static void AssociateItineraryDetailsWithDays(TravelItineraryWebsiteContext context)
        {
            context.ChangeTracker.AutoDetectChangesEnabled = false; // Important for performance

            foreach (var itinerary in context.Itinerary.Local.ToList())
            {
                var days = itinerary.Days.OrderBy(d => d.Date).ToList(); // Order Days by date!

                foreach (var itineraryDetail in context.ItineraryDetail.Local.ToList())
                {
                    if (itineraryDetail.ItineraryId == itinerary.ItineraryId)
                    {
                        for (int i = 0; i < days.Count; i++)
                        {
                            if (itineraryDetail.StartDate <= days[i].Date) // Or your chosen criteria
                            {
                                itineraryDetail.DayId = days[i].DayId;
                                break;
                            }
                        }
                    }
                }
            }

            context.ChangeTracker.AutoDetectChangesEnabled = true;
            context.SaveChanges(); // Save the DayId changes
        }
    }
}
