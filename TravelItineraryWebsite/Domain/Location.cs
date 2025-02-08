namespace TravelItineraryWebsite.Domain
{
    public class Location
    {
        public int LocationId { get; set; }
        public string? Address { get; set; }
        public string? PlaceId { get; set; }
        public double? Latitude { get; set; } = 0;
        public double? Longitude { get; set; } = 0;
        //public int? ItineraryDetailId { get; set; }
        public LocationType LocationType { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
    }

    public enum LocationType
    {
        None,
        Address,
        City,
        Region,
        Country
    }
}
