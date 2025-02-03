namespace TravelItineraryWebsite.Domain
{
    public class Transport
    {
        public int TransportId { get; set; }
        public int DepatureLocationId { get; set; }
        public int ArrivalLocationId { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Location DepatureLocation { get; set; }
        public Location ArrivalLocation { get; set; }
        public int ItineraryDetailId { get; set; }
        public ItineraryDetail ItineraryDetail { get; set; }
    }
}
