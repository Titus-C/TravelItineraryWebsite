namespace TravelItineraryWebsite.Domain
{
    public class Guide : BaseDomainModel
    {
        public int GuideId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Views { get; set; }
        public int Saves { get; set; }
        public int ItineraryId { get; set; }
    }
}
