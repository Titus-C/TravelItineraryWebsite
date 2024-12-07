namespace TravelItineraryWebsite.Domain
{
    public class User : BaseDomainModel
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
    }
}
