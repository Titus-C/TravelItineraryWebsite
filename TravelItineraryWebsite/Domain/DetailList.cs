namespace TravelItineraryWebsite.Domain
{
    public class DetailList : BaseDomainModel
    {
        public int DetailListId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
    }
}
