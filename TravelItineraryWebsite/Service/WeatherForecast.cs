using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace TravelItineraryWebsite.Service
{
    public class WeatherForecast
    {
        private readonly HttpClient _httpClient;

        // Inject HttpClient into the service
        public WeatherForecast(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Method to fetch weather data from WeatherAPI
        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            string apiKey = "25f2a29d9512494fbf390229250601"; // Replace with your WeatherAPI key
            string url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}";

            var response = await _httpClient.GetStringAsync(url);
            var weatherData = JsonConvert.DeserializeObject<WeatherData>(response);
            return weatherData;
        }
    }

    public class WeatherData
    {
        public Location Location { get; set; }
        public CurrentWeather Current { get; set; }
        public Forecast Forecast { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Localtime { get; set; }
    }

    public class CurrentWeather
    {
        public float TempC { get; set; }
        public float TempF { get; set; }
        public int Humidity { get; set; }
        public string Condition { get; set; }
    }

    public class Forecast
    {
        public ForecastDay[] ForecastDay { get; set; }
    }

    public class ForecastDay
    {
        public string Date { get; set; }
        public Day Day { get; set; }
    }

    public class Day
    {
        public float MaxtempC { get; set; }
        public float MintempC { get; set; }
        public float AvgtempC { get; set; }
        public float MaxwindKph { get; set; }
        public int DailyChanceOfRain { get; set; }
    }


}
