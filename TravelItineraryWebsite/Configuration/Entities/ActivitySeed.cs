using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Configuration.Entities
{
    public class ActivitySeed : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            var activityCategories = new List<ActivityCategory>
            {
                new ActivityCategory { ActivityCategoryId = 1, Name="Wanton Mee", ItineraryId = 1 },
                new ActivityCategory { ActivityCategoryId = 2, Name="Eating", ItineraryId=2 },
                new ActivityCategory { ActivityCategoryId = 3, Name="Snow Spots", ItineraryId=3 }
            };
            
            builder.HasData(activityCategories);

            var activities = new List<Activity>
            {
                new Activity
                {
                    ActivityId = 1,
                    Name="Hong Kong Wanton Mee",
                    Description="Trying all the best wanton mee in Hong Kong",
                    ActivityCategoryId = 1
                },
                new Activity
                {
                    ActivityId = 2,
                    Name="Osaka Udon",
                    Description="Feasting on delicious Udon in Osaka",
                    ActivityCategoryId = 2
                },
                new Activity
                {
                    ActivityId = 3,
                    Name="Winter Attractions",
                    Description="Exploring snowy winter locations in Central Japan",
                    ActivityCategoryId = 3
                }
            };

            builder.HasData(activities);

            var activityLocations = new List<ActivityLocation>
            {
                new ActivityLocation { ActivityId = 1, LocationId = 4 },
                new ActivityLocation { ActivityId = 1, LocationId = 5 },
                new ActivityLocation { ActivityId = 2, LocationId = 2 },
                new ActivityLocation { ActivityId = 2, LocationId = 7 },
                new ActivityLocation { ActivityId = 3, LocationId = 3 },
                new ActivityLocation { ActivityId = 3, LocationId = 6 },
            };

            builder.HasData(activityLocations);
        }
    }
}
