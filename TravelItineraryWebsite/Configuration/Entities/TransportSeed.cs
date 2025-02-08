using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Configuration.Entities
{
    public class TransportSeed : IEntityTypeConfiguration<Transport>
    {
        public void Configure(EntityTypeBuilder<Transport> builder)
        {
            builder.HasData(
                new Transport
                {
                    TransportId = 1,
                    DepartureLocationId = 12,
                    ArrivalLocationId = 8,
                    StartTime = new DateTime(2025, 3, 6, 8, 0, 0),
                    Duration = TimeSpan.FromHours(1)
                },
                new Transport
                {
                    TransportId = 2,
                    DepartureLocationId = 13,
                    ArrivalLocationId = 9,
                    StartTime = new DateTime(2025, 6, 14, 11, 0, 0),
                    Duration = TimeSpan.FromMinutes(30)
                }
            );
        }
    }
}
