using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite.Data;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Configuration.Entities
{
    public class ItineraryDetailSeed : IEntityTypeConfiguration<ItineraryDetail>
    {
        private readonly TravelItineraryWebsiteContext _context;

        public ItineraryDetailSeed(TravelItineraryWebsiteContext context)
        {
            _context = context;
        }

        public void Configure(EntityTypeBuilder<ItineraryDetail> builder)
        {
            //// Activity, Accommodation, Transport
            //builder.HasData(
            //    new ItineraryDetail { 
            //        ItineraryDetailId = 1,
            //        ActivityId = 1,
            //        EntityType = ItineraryDetailType.Activity,
            //        ItineraryId = 1,
            //    }
            //);

            {
                var itineraryDetails = new List<ItineraryDetail>();

                // 1. Get the seeded Itineraries using .Local
                var itineraries = _context.Itinerary.Local.ToList();

                foreach (var itinerary in itineraries)
                {
                    // 2. Create ItineraryDetail entries for EACH Itinerary
                    if (itinerary.ItineraryId == 1) // Example: Details for Itinerary 1
                    {
                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 1,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Activity,
                            ActivityId = 1 // Example
                        });

                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 2,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Location,
                            LocationId = 1 // Example
                        });

                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 3,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Accommodation,
                            AccommodationId = 1 // Example
                        });

                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 8,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Transport,
                            TransportId = 1 // Example
                        });
                    }
                    else if (itinerary.ItineraryId == 2) // Example: Details for Itinerary 2
                    {
                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 4,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Activity,
                            ActivityId = 2 // Example
                        });
                        // ... more details for itinerary 2
                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 5,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Accommodation,
                            AccommodationId = 2
                        });
                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 9,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Transport,
                            TransportId = 2 // Example
                        });
                    }
                    else if (itinerary.ItineraryId == 3) // Example: Details for Itinerary 3
                    {
                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 6,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Activity,
                            ActivityId = 3 // Example
                        });
                        // ... more details for itinerary 3
                        itineraryDetails.Add(new ItineraryDetail
                        {
                            ItineraryDetailId = 7,
                            ItineraryId = itinerary.ItineraryId, // Correctly set ItineraryId
                                                                 // ... other properties
                            EntityType = ItineraryDetailType.Accommodation,
                            AccommodationId = 3
                        });
                    }
                }

                builder.HasData(itineraryDetails);
            } // End of using block (context is disposed)
        }
    }
}
