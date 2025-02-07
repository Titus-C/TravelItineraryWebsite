namespace TravelItineraryWebsite.Domain
{
    public class Accommodation
    {
        public int AccommodationId { get; set; }
        public string? Name { get; set; }
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
        public decimal Cost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public int ItineraryDetailId { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
    }
}
