namespace TravelItineraryWebsite.Domain
{
    public class Destination : BaseDomainModel
    {
        public int DestinationId { get; set; }
        public string? DestinationName { get; set; }
        public string? DestinationLocation { get; set; }
        public string? DestinationDescription { get; set; }
        public int ItineraryDetailId { get; set; }
        public int ActivityId { get; set; }
        public int TransportId { get; set; }
    }
}
