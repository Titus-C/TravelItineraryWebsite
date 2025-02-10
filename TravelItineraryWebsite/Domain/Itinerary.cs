namespace TravelItineraryWebsite.Domain
{
    public class Itinerary : BaseDomainModel
    {
        public int ItineraryId { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
    }
}
