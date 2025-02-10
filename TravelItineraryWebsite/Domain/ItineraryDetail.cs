using System.Security.Cryptography.Xml;

namespace TravelItineraryWebsite.Domain
{
    public class ItineraryDetail : BaseDomainModel
    {
        public int ItineraryDetailId { get; set; }
        public string? Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
        public int? ActivityId { get; set; }
        public Activity? Activity { get; set; }
        public int? AccommodationId { get; set; }
        public Accomodation? Accommodation { get; set; }
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
        //public int? TransportId { get; set; }
        //public Transport? Transport { get; set; }
        public int? DayId { get; set; }
        public Day? Day { get; set; }
        public int? ExpenseId { get; set; }
        public Expense? Expense { get; set; }   
    }
}
