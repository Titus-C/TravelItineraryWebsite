using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Configuration.Entities
{
    public class ItinerarySeed : IEntityTypeConfiguration<Itinerary>
    {
        public void Configure(EntityTypeBuilder<Itinerary> builder)
        {
            var itineraries = new List<Itinerary>();

            // Example 1: Using the constructor with all parameters
            var itinerary1 = new Itinerary(
                "Hong Kong and Shenzhen Trip",
                new DateTime(2025, 3, 6), // Example start date
                new DateTime(2025, 3, 11), // Example end date
                "Hong Kong", // Example location
                LocationType.City,
                22.3028, // Example latitude
                114.1772 // Example longitude
            );
            itinerary1.ItineraryId = 1; // Must set ID explicitly

            itineraries.Add(itinerary1);

            // Example 2: Using a constructor with fewer parameters
            var itinerary2 = new Itinerary(
                "Osaka Food Trip",
                new DateTime(2025, 6, 14),
                new DateTime(2025, 6, 21),
                "Osaka",
                LocationType.City
            );
            itinerary2.ItineraryId = 2; // Must set ID explicitly
            itineraries.Add(itinerary2);

            // Example 3: Using the parameterless constructor and setting properties
            var itinerary3 = new Itinerary
            {
                Name = "Japan Winter Trip",
                StartDate = new DateTime(2025, 12, 15),
                EndDate = new DateTime(2025, 12, 25)
            };
            itinerary3.ItineraryId = 3; // Must set ID explicitly
            itineraries.Add(itinerary3);

            builder.HasData(itineraries);
        }
    }
}
