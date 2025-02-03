namespace TravelItineraryWebsite.Domain
{
    public class ItineraryDetail : BaseDomainModel
    {
        public int ItineraryDetailId { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
    }
}
