namespace TravelItineraryWebsite.Domain
{
    public class Transport
    {
        public int TransportId { get; set; }
        public int DepartureLocationId { get; set; }
        public int ArrivalLocationId { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Location DepartureLocation { get; set; }
        public Location ArrivalLocation { get; set; }
        //public int ItineraryDetailId { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
    }
}
