namespace TravelItineraryWebsite.Domain
{
    public class ActivityCategory
    {
        public int ActivityCategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        // Add User props later
        public int? ItineraryId { get; set; } 
        public Itinerary? Itinerary { get; set; }
        public ICollection<Activity> Activities { get; } = new List<Activity>();
    }
}
