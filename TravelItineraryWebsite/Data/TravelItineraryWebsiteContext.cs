using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Data
{
    public class TravelItineraryWebsiteContext : DbContext
    {
        public TravelItineraryWebsiteContext (DbContextOptions<TravelItineraryWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<TravelItineraryWebsite.Domain.User> User { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.Itinerary> Itinerary { get; set; } = default!;
        public DbSet<TravelItineraryWebsite.Domain.ItineraryDetail> ItineraryDetail { get; set; } = default!;
    }
}
