namespace TravelItineraryWebsite.Domain
{
    public class Location
    {
        public int LocationId { get; set; }
        public string? Address { get; set; }
        public string? PlaceId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int? ItineraryDetailId { get; set; }
        public ItineraryDetail? ItineraryDetail { get; set; }
    }
}
