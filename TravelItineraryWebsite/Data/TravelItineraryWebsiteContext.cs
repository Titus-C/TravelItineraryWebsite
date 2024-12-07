using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Xml;
using TravelItineraryWebsite.Data;

//namespace TravelItineraryWebsite.Data
//{
//    public class TravelItineraryWebsiteContext(DbContextOptions<TravelItineraryWebsiteContext> options) : IdentityDbContext<TravelItineraryWebsiteUser>(options)
//    {

//    }
//}


namespace TravelItineraryWebsite.Data
{
    public class TravelItineraryWebsiteContext : IdentityDbContext<TravelItineraryWebsiteUser>
    {
        public TravelItineraryWebsiteContext(DbContextOptions<TravelItineraryWebsiteContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your domain models here
        //public DbSet<MyEntity> MyEntities { get; set; }
    }
}
