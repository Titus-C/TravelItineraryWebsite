namespace TravelItineraryWebsite.Domain
{
    public class Activity : BaseDomainModel
    {
        public int ActivityId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Address { get; set; }
        public string? PlaceId { get; set; }
        public int ItineraryDetailId { get; set; }
        public ItineraryDetail ItineraryDetail { get; set; }
    }
}
