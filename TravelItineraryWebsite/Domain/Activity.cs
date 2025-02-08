namespace TravelItineraryWebsite.Domain
{
    public class Activity : BaseDomainModel
    {
        public int ActivityId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        //public string? Category { get; set; }
        //public int? LocationId { get; set; }
        //public Location? Location { get; set; }
        public int? ActivityCategoryId { get; set; }
        public ActivityCategory ActivityCategory { get; set; }
        public ICollection<ActivityLocation> ActivityLocations { get; } = new List<ActivityLocation>();
        public ICollection<Location> Locations { get; } = new List<Location>();
        //public int ItineraryDetailId { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
    }
}
