using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
//dotnet add package Newtonsoft.Json --version 13.0.3 (copy this into package manager)
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
            string url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}&aqi=no";

            var response = await _httpClient.GetStringAsync(url);
            try 
            {
                var weatherData = JsonConvert.DeserializeObject<WeatherData>(response);
                System.Diagnostics.Debug.WriteLine($"Raw API Response: {response}");
                return weatherData;
            }
            catch (JsonException ex)
            {
                System.Diagnostics.Debug.WriteLine($"JSON Deserialization failed: {ex.Message}");
                return null;
            }
        }
    }

    public class WeatherData
    {
        public Location Location { get; set; }
        public Current Current { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Localtime { get; set; }

        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Localtime_epoch { get; set; }

    }

    public class Current
    {
        public float Temp_C { get; set; }
        public float Temp_F { get; set; }
        public int Humidity { get; set; }
        public float Wind_mph { get; set; }
        public float Wind_kph { get; set; }
        public WeatherCondition condition { get; set; }
    }

    public class WeatherCondition
    {
        
        public string Text { get; set; }

        public string Icon { get; set; }
        public string FullIconUrl => $"https:{Icon}";
    }

}
