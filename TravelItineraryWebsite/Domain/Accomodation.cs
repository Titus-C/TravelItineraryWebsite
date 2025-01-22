namespace TravelItineraryWebsite.Domain
{
    public class Accomodation : BaseDomainModel
    {
        public int AccomodationId { get; set; }
        public string? AccomodationName { get; set; }
        public string? AccomodationAddress { get; set; }
        public int AccomodationCost { get; set; }
        public int ItineraryDetailId { get; set; }
    }
}
