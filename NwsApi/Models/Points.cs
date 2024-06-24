using System.Text.Json.Serialization;

namespace NwsApi.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class Points
{
    [JsonPropertyName("@context")]
    public List<object>? context { get; set; }

    [JsonPropertyName("id")]
    public string? id { get; set; }

    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("geometry")]
    public Geometry? geometry { get; set; }

    [JsonPropertyName("properties")]
    public Properties? properties { get; set; }
}

public class Bearing
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }
}

public class Distance
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }
}

public class Geometry
{
    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("coordinates")]
    public List<double?>? coordinates { get; set; }
}

public class Properties
{
    [JsonPropertyName("@id")]
    public string? id { get; set; }

    [JsonPropertyName("@type")]
    public string? type { get; set; }

    [JsonPropertyName("cwa")]
    public string? cwa { get; set; }

    [JsonPropertyName("forecastOffice")]
    public string? forecastOffice { get; set; }

    [JsonPropertyName("gridId")]
    public string? gridId { get; set; }

    [JsonPropertyName("gridX")]
    public int? gridX { get; set; }

    [JsonPropertyName("gridY")]
    public int? gridY { get; set; }

    /// <summary>
    /// URL for forecast
    /// </summary>
    [JsonPropertyName("forecast")]
    public string? forecast { get; set; }

    [JsonPropertyName("forecastHourly")]
    public string? forecastHourly { get; set; }

    [JsonPropertyName("forecastGridData")]
    public string? forecastGridData { get; set; }

    [JsonPropertyName("observationStations")]
    public string? observationStations { get; set; }

    [JsonPropertyName("relativeLocation")]
    public RelativeLocation? relativeLocation { get; set; }

    [JsonPropertyName("forecastZone")]
    public string? forecastZone { get; set; }

    [JsonPropertyName("county")]
    public string? county { get; set; }

    [JsonPropertyName("fireWeatherZone")]
    public string? fireWeatherZone { get; set; }

    [JsonPropertyName("timeZone")]
    public string? timeZone { get; set; }

    [JsonPropertyName("radarStation")]
    public string? radarStation { get; set; }

    [JsonPropertyName("city")]
    public string? city { get; set; }

    [JsonPropertyName("state")]
    public string? state { get; set; }

    [JsonPropertyName("distance")]
    public Distance? distance { get; set; }

    [JsonPropertyName("bearing")]
    public Bearing? bearing { get; set; }
}

public class RelativeLocation
{
    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("geometry")]
    public Geometry? geometry { get; set; }

    [JsonPropertyName("properties")]
    public Properties? properties { get; set; }
}

