namespace TravelItineraryWebsite.Domain
{
    public class Transport : BaseDomainModel
    {
        public int TransportId { get; set; }
        public string? TransportName { get; set; }
        public string? TransportDuration { get; set; }
        public DateTime TransportDepartureTime { get; set; }
        public DateTime TransportArrivalTime { get; set; }
        public int ItineraryDetailId { get; set; }
        
    }
}
