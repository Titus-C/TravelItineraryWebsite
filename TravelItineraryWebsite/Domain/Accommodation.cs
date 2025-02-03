namespace TravelItineraryWebsite.Domain
{
    public class Accommodation
    {
        public int AccommodationId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PlaceId { get; set; }
        public decimal Cost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ItineraryDetailId { get; set; }
        public ItineraryDetail ItineraryDetail { get; set; }
    }
}
