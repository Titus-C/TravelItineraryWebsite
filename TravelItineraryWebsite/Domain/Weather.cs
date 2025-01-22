namespace TravelItineraryWebsite.Domain
{
    public class Weather : BaseDomainModel
    {
        public int WeatherId {  get; set; }
        public string? WeatherName { get; set; }
        public string? WeatherForecast { get; set; }
        public string? WeatherDescription { get; set; }
        public int DestinationId { get; set; }
        public int LocationId { get; set; }
    }
}
