namespace TravelItineraryWebsite.Domain
{
    public class Activity : BaseDomainModel
    {
        public int ActivityId { get; set; }
        public string? ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
        public string? ActivityAddress { get; set; }
        public int ItineraryDetailId { get; set; }
    }
}
