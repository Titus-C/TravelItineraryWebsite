namespace TravelItineraryWebsite.Domain
{
    public class Location : BaseDomainModel
    {
        public int LocationId { get; set; }
        public string? Address { get; set; }
        public string? PlaceId { get; set; }
        public decimal Latitude { get; set; } = decimal.Zero;
        public decimal Longitude { get; set; } = decimal.Zero;
        //public int? ItineraryDetailId { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
    }
}
