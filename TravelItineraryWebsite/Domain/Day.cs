namespace TravelItineraryWebsite.Domain
{
    public class Day
    {
        public int DayId { get; set; }
        public DateTime Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; set; } = new List<ItineraryDetail>();
    }
}
