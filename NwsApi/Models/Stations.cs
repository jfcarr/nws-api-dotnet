using System.Text.Json.Serialization;

namespace NwsApi.Models;

public class Stations
{
    [JsonPropertyName("@context")]
    public List<object>? context { get; set; }

    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("features")]
    public List<Feature>? features { get; set; }

    [JsonPropertyName("observationStations")]
    public List<string>? observationStations { get; set; }

    [JsonPropertyName("pagination")]
    public Pagination? pagination { get; set; }
}

public class StationElevation
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }
}

public class Feature
{
    [JsonPropertyName("id")]
    public string? id { get; set; }

    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("geometry")]
    public StationGeometry? geometry { get; set; }

    [JsonPropertyName("properties")]
    public StationProperties? properties { get; set; }
}

public class StationGeometry
{
    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("coordinates")]
    public List<double?>? coordinates { get; set; }
}

public class Pagination
{
    [JsonPropertyName("next")]
    public string? next { get; set; }
}

public class StationProperties
{
    [JsonPropertyName("@id")]
    public string? id { get; set; }

    [JsonPropertyName("@type")]
    public string? type { get; set; }

    [JsonPropertyName("elevation")]
    public StationElevation? elevation { get; set; }

    [JsonPropertyName("stationIdentifier")]
    public string? stationIdentifier { get; set; }

    [JsonPropertyName("name")]
    public string? name { get; set; }

    [JsonPropertyName("timeZone")]
    public string? timeZone { get; set; }

    [JsonPropertyName("forecast")]
    public string? forecast { get; set; }

    [JsonPropertyName("county")]
    public string? county { get; set; }

    [JsonPropertyName("fireWeatherZone")]
    public string? fireWeatherZone { get; set; }
}
