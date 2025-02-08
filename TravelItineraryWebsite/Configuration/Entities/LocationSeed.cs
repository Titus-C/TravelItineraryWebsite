using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite.Domain;

namespace TravelItineraryWebsite.Configuration.Entities
{
    public class LocationSeed : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location
                {
                    LocationId = 1,
                    Address = "Victoria Harbour",
                    PlaceId = "ChIJR3bnzBMBBDQRrodrPnMlcVg",
                    Latitude = 22.307446,
                    Longitude = 114.16771,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 2,
                    Address = "Mitsushima Shin-uchi",
                    PlaceId = "ChIJTexD3aHhAGARNrzMqjfQG6Y",
                    Latitude = 34.733974,
                    Longitude = 135.582807,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 3,
                    Address = "Shirakawa-go",
                    PlaceId = "ChIJ5yW_trBx-F8R-AVYnbtRxcwY",
                    Latitude = 36.257797,
                    Longitude = 136.906198,
                    LocationType = LocationType.City
                },
                new Location
                {
                    LocationId = 4,
                    Address = "Lau Sum Kee",
                    PlaceId = "ChIJvxd8mOcBBDQRSoZgKiql49A",
                    Latitude = 22.331783,
                    Longitude = 114.163192,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 5,
                    Address = "Ying Kee",
                    PlaceId = "ChIJJzqTNYf_AzQRwKZRoDRERbw",
                    Latitude = 22.285089,
                    Longitude = 114.142386,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 6,
                    Address = "Shinhotaka Ropeway",
                    PlaceId = "ChIJLUAe875PHWARkR1e5ffwR9k",
                    Latitude = 36.285792,
                    Longitude = 137.575262,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 7,
                    Address = "Unotake Kasu Udon",
                    PlaceId = "ChIJhfXfdxHnAGARxQbdzydTMTc",
                    Latitude = 34.670552,
                    Longitude = 135.499302,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 8,
                    Address = "BEST WESTERN PLUS Hotel Hong Kong",
                    PlaceId = "ChIJewz8QYH_AzQRzRa9Gq-0NsE",
                    Latitude = 22.28728,
                    Longitude = 114.139121,
                    LocationType = LocationType.Address
                },
                new Location
                { 
                    LocationId = 9,
                    Address = "Centrage Ark Ueshio",
                    PlaceId = "ChIJCdMda1DnAGARSFh3OgTKhFk",
                    Latitude = 34.663462,
                    Longitude = 135.51679,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 10,
                    Address = "Onyado Yuinosho",
                    PlaceId = "ChIJvXvOjU9x-F8RAWDVsroNuBg",
                    Latitude = 36.277239,
                    Longitude = 136.902331,
                    LocationType= LocationType.Address
                },
                new Location
                {
                    LocationId = 11,
                    Address = "Onyado Yuinosho",
                    PlaceId = "ChIJvXvOjU9x-F8RAWDVsroNuBg",
                    Latitude = 36.277239,
                    Longitude = 136.902331,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 12,
                    Address = "Hong Kong International Airport",
                    PlaceId = "ChIJncZGzPPiAzQRnjaSGIKQ9fk",
                    Latitude = 22.313474,
                    Longitude = 113.913728,
                    LocationType = LocationType.Address
                },
                new Location
                {
                    LocationId = 13,
                    Address = "Osaka Station",
                    PlaceId = "ChIJC6fjlY3mAGARSshZ6CLIrhs",
                    Latitude = 34.702485,
                    Longitude = 135.495951,
                    LocationType = LocationType.Address
                }
            );
        }
    }
}
