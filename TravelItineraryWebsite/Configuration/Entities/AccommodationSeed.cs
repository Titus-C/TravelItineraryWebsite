using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Configuration.Entities
{
    public class AccommodationSeed : IEntityTypeConfiguration<Accommodation>
    {
        public void Configure(EntityTypeBuilder<Accommodation> builder)
        {
            builder.HasData(
                new Accommodation
                {
                    AccommodationId = 1,
                    Name = "BEST WESTERN PLUS Hotel Hong Kong",
                    LocationId = 8,
                    Cost = 750,
                    StartDate = new DateTime(2025, 3, 6),
                    EndDate = new DateTime(2025, 3, 11)
                },
                new Accommodation
                {
                    AccommodationId = 2,
                    Name = "Centrage Ark Ueshio",
                    LocationId = 9,
                    Cost = 500,
                    StartDate = new DateTime(2025, 6, 14),
                    EndDate = new DateTime(2025, 6, 21),
                },
                new Accommodation
                {
                    AccommodationId = 3,
                    Name = "Onyado Yuinosho",
                    LocationId = 10,
                    Cost=1000,
                    StartDate = new DateTime(2025, 12, 19),
                    EndDate = new DateTime(2025, 12, 25)
                }
            );
        }
    }
}
