using NwsApi;
using NwsApi.Helpers;
using NwsApi.Models;

internal class Program
{
    private static async Task Main(string[] args)
    {
        ApiManager apiManager = new();

        Points points = await apiManager.GetPointData(39.747, -84.536);  // West Alexandria, Ohio

        Stations stations = await apiManager.GetStationData(
            points.properties?.gridId ?? "???",
            points.properties?.gridX ?? 0,
            points.properties?.gridY ?? 0
        );

        if (stations.features is not null)
        {
            Console.WriteLine("----------");

            string stationIdentifier = stations.features[0].properties?.stationIdentifier ?? "";
            string stationName = stations.features[0].properties?.name ?? "";

            Console.WriteLine($"Closest station is {stationIdentifier} ({stationName})");

            Observations observations = await apiManager.GetObservationData(stationIdentifier);

            Console.WriteLine("----------");

            var currentTemperature = Math.Round(Conversions.CelsiusToFahrenheit(observations.properties?.temperature?.value ?? 0), 0);
            var feelsLikeTemperature = Math.Round(Conversions.CelsiusToFahrenheit(Complex.GetFeelsLikeTemperature(observations)), 0);
            Console.WriteLine($"Currently: {observations.properties?.textDescription}, {currentTemperature} F (feels like {feelsLikeTemperature} F)");
        }

        Forecast forecast = await apiManager.GetForecastData(
            points.properties?.gridId ?? "???",
            points.properties?.gridX ?? 0,
            points.properties?.gridY ?? 0
        );

        if (forecast.properties?.periods is not null)
        {
            Console.WriteLine("----------");
            Console.WriteLine("Forecast:");
            foreach (var item in forecast.properties.periods)
            {
                // Console.WriteLine($"\t{item.name} -> {item.detailedForecast}");
                Console.WriteLine($"\t{item.name}");
                Console.WriteLine($"\t\t{item.detailedForecast}");
            }
        }
    }
}