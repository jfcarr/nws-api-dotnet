using System.Text.Json.Serialization;

namespace NwsApi.Models;

public class Forecast
{
    [JsonPropertyName("@context")]
    public List<object>? context { get; set; }

    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("geometry")]
    public ForecastGeometry? geometry { get; set; }

    [JsonPropertyName("properties")]
    public ForecastProperties? properties { get; set; }
}

public class Elevation
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }
}

public class ForecastGeometry
{
    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("coordinates")]
    public List<List<List<double?>>>? coordinates { get; set; }
}

public class Period
{
    [JsonPropertyName("number")]
    public int? number { get; set; }

    [JsonPropertyName("name")]
    public string? name { get; set; }

    [JsonPropertyName("startTime")]
    public DateTime? startTime { get; set; }

    [JsonPropertyName("endTime")]
    public DateTime? endTime { get; set; }

    [JsonPropertyName("isDaytime")]
    public bool? isDaytime { get; set; }

    [JsonPropertyName("temperature")]
    public int? temperature { get; set; }

    [JsonPropertyName("temperatureUnit")]
    public string? temperatureUnit { get; set; }

    [JsonPropertyName("temperatureTrend")]
    public string? temperatureTrend { get; set; }

    [JsonPropertyName("probabilityOfPrecipitation")]
    public ProbabilityOfPrecipitation? probabilityOfPrecipitation { get; set; }

    [JsonPropertyName("windSpeed")]
    public string? windSpeed { get; set; }

    [JsonPropertyName("windDirection")]
    public string? windDirection { get; set; }

    [JsonPropertyName("icon")]
    public string? icon { get; set; }

    [JsonPropertyName("shortForecast")]
    public string? shortForecast { get; set; }

    [JsonPropertyName("detailedForecast")]
    public string? detailedForecast { get; set; }
}

public class ProbabilityOfPrecipitation
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }
}

public class ForecastProperties
{
    [JsonPropertyName("units")]
    public string? units { get; set; }

    [JsonPropertyName("forecastGenerator")]
    public string? forecastGenerator { get; set; }

    [JsonPropertyName("generatedAt")]
    public DateTime? generatedAt { get; set; }

    [JsonPropertyName("updateTime")]
    public DateTime? updateTime { get; set; }

    [JsonPropertyName("validTimes")]
    public string? validTimes { get; set; }

    [JsonPropertyName("elevation")]
    public Elevation? elevation { get; set; }

    [JsonPropertyName("periods")]
    public List<Period>? periods { get; set; }
}

