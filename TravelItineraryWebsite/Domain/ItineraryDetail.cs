using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelItineraryWebsite.Domain
{
    public enum ItineraryDetailType
    {
        None,
        Activity,
        Accommodation,
        Location,
        Transport,
        Expense
    }

    public class ItineraryDetail : BaseDomainModel
    {
        public int ItineraryDetailId { get; set; }
        //public string? Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        //public string? Description { get; set; }
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }

        // Foreign Keys (Nullable)
        private int? _activityId;
        public int? ActivityId
        {
            get => _activityId;
            set
            {
                _activityId = value;
                ValidateRelatedEntities();
                if (value.HasValue) EntityType = ItineraryDetailType.Activity;
            }
        }
        public Activity? Activity { get; set; }

        private int? _accommodationId;
        public int? AccommodationId
        {
            get => _accommodationId;
            set
            {
                _accommodationId = value;
                ValidateRelatedEntities();
                if (value.HasValue) EntityType = ItineraryDetailType.Accommodation;
            }
        }
        public Accommodation? Accommodation { get; set; }

        private int? _locationId;
        public int? LocationId
        {
            get => _locationId;
            set
            {
                _locationId = value;
                ValidateRelatedEntities();
                if (value.HasValue) EntityType = ItineraryDetailType.Location;
            }
        }
        public Location? Location { get; set; }

        private int? _transportId;
        public int? TransportId
        {
            get => _transportId;
            set
            {
                _transportId = value;
                ValidateRelatedEntities();
                if (value.HasValue) EntityType = ItineraryDetailType.Transport;
            }
        }
        public Transport? Transport { get; set; }
        public int? DayId { get; set; }
        public Day? Day { get; set; }

        public int Order { get; set; }

        [NotMapped]
        public object? RelatedEntity =>
        (object?)Activity ?? (object?)Accommodation ?? (object?)Location ?? (object?)Transport;

        [NotMapped]
        public string DisplayName
        {
            get
            {
                switch (EntityType)
                {
                    case ItineraryDetailType.Activity:
                        return Activity?.Name ?? ""; // Null-coalescing operator
                    case ItineraryDetailType.Accommodation:
                        return Accommodation?.Name ?? "";
                    case ItineraryDetailType.Location:
                        return Location?.Address ?? "";
                    case ItineraryDetailType.Transport:
                        return $"Travel from {Transport?.DepartureLocation?.Address} to {Transport?.ArrivalLocation?.Address}" ?? "";
                    // ... other types
                    default:
                        return "Itinerary Detail";
                }
            }
        }

        public ItineraryDetailType EntityType { get; set; } = ItineraryDetailType.None; // Initialize to None

        // Validation Method
        public void ValidateRelatedEntities()
        {
            int relatedEntityCount = 0;
            if (ActivityId.HasValue) relatedEntityCount++;
            if (AccommodationId.HasValue) relatedEntityCount++;
            if (LocationId.HasValue) relatedEntityCount++;
            if (TransportId.HasValue) relatedEntityCount++;

            if (relatedEntityCount > 1)
            {
                throw new InvalidOperationException("An ItineraryDetail can only have one related entity.");
            }
            else if (relatedEntityCount == 0)
            {
                EntityType = ItineraryDetailType.None;
            }
        }

    }
}
