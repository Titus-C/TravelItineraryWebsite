namespace TravelItineraryWebsite.Domain
{
    public class Itinerary : BaseDomainModel
    {
        public int ItineraryId { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
        public ICollection<DetailList> DetailLists { get; } = new List<DetailList>();
        public ICollection<ActivityCategory> ItineraryCategories { get; } = new List<ActivityCategory>();
        public ICollection<Day> Days { get; } = new List<Day>();
        public Itinerary(string name, DateTime startDate, DateTime endDate, string locationName, LocationType locationType, double? locationLat, double? locationLng)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            List<Day> days = new List<Day>();
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                Day day = new Day();
                day.Date = i;
                days.Add(day);
            }
            this.Days = days;
            var location = new Location
            {
                Address = locationName,
                Latitude = locationLat,
                Longitude = locationLng,
                LocationType = locationType
            };
            var itineraryDetail = new ItineraryDetail { Location = location };
            ItineraryDetails.Add(itineraryDetail);
        }

        public Itinerary(string name, DateTime startDate, DateTime endDate, string locationName, LocationType locationType)
            : this(name, startDate, endDate, locationName, locationType, null, null)
        {

        }

        public Itinerary(string name, DateTime startDate, DateTime endDate)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public Itinerary() { }
    }
}
