namespace TravelItineraryWebsite.Domain
{
    public class Location : BaseDomainModel
    {
        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Coordinates { get; set; }
        public int ItineraryDetailId { get; set; }
    }
}
