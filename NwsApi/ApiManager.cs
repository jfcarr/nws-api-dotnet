using NwsApi.Models;
using System.Text.Json;

namespace NwsApi;

public class ApiManager
{
    private async Task<string> CallApi(string url)
    {
        string body = "";

        HttpClient client = new();
        HttpRequestMessage request = new()
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url),
            Headers =
            {
                { "user-agent", "nws-api" }
            },
        };

        using (HttpResponseMessage response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();

            body = await response.Content.ReadAsStringAsync();
        }

        return body;
    }

    public async Task<Points> GetPointData(double latitude, double longitude)
    {
        string body = await CallApi($"https://api.weather.gov/points/{latitude},{longitude}");

        Points? points = JsonSerializer.Deserialize<Points>(body);

        return points ?? new Points();
    }

    public async Task<Forecast> GetForecastData(string gridId, int gridX, int gridY)
    {
        string body = await CallApi($"https://api.weather.gov/gridpoints/{gridId}/{gridX},{gridY}/forecast");

        Forecast? forecast = JsonSerializer.Deserialize<Forecast>(body);

        return forecast ?? new Forecast();
    }

    public async Task<Stations> GetStationData(string gridId, int gridX, int gridY)
    {
        string body = await CallApi($"https://api.weather.gov/gridpoints/{gridId}/{gridX},{gridY}/stations");

        Stations? stations = JsonSerializer.Deserialize<Stations>(body);

        return stations ?? new Stations();
    }

    public async Task<Observations> GetObservationData(string stationId)
    {
        string body = await CallApi($"https://api.weather.gov/stations/{stationId}/observations/latest");

        Observations? observations = JsonSerializer.Deserialize<Observations>(body);

        return observations ?? new Observations();
    }
}