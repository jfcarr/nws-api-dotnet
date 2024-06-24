using System.Text.Json.Serialization;

namespace NwsApi.Models;

public class Observations
{
    [JsonPropertyName("@context")]
    public List<object>? context { get; set; }

    [JsonPropertyName("id")]
    public string? id { get; set; }

    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("geometry")]
    public ObservationGeometry? geometry { get; set; }

    [JsonPropertyName("properties")]
    public ObservationProperties? properties { get; set; }
}

public class BarometricPressure
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class Base
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }
}

public class CloudLayer
{
    [JsonPropertyName("base")]
    public Base? @base { get; set; }

    [JsonPropertyName("amount")]
    public string? amount { get; set; }
}

public class Dewpoint
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class ObservationElevation
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }
}

public class ObservationGeometry
{
    [JsonPropertyName("type")]
    public string? type { get; set; }

    [JsonPropertyName("coordinates")]
    public List<double?>? coordinates { get; set; }
}

public class HeatIndex
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class MaxTemperatureLast24Hours
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public object? value { get; set; }
}

public class MinTemperatureLast24Hours
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public object? value { get; set; }
}

public class PrecipitationLast3Hours
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public object? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class PrecipitationLast6Hours
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public object? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class PrecipitationLastHour
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class ObservationProperties
{
    [JsonPropertyName("@id")]
    public string? id { get; set; }

    [JsonPropertyName("@type")]
    public string? type { get; set; }

    [JsonPropertyName("elevation")]
    public ObservationElevation? elevation { get; set; }

    [JsonPropertyName("station")]
    public string? station { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime? timestamp { get; set; }

    [JsonPropertyName("rawMessage")]
    public string? rawMessage { get; set; }

    [JsonPropertyName("textDescription")]
    public string? textDescription { get; set; }

    [JsonPropertyName("icon")]
    public string? icon { get; set; }

    [JsonPropertyName("presentWeather")]
    public List<object>? presentWeather { get; set; }

    [JsonPropertyName("temperature")]
    public Temperature? temperature { get; set; }

    [JsonPropertyName("dewpoint")]
    public Dewpoint? dewpoint { get; set; }

    [JsonPropertyName("windDirection")]
    public WindDirection? windDirection { get; set; }

    [JsonPropertyName("windSpeed")]
    public WindSpeed? windSpeed { get; set; }

    [JsonPropertyName("windGust")]
    public WindGust? windGust { get; set; }

    [JsonPropertyName("barometricPressure")]
    public BarometricPressure? barometricPressure { get; set; }

    [JsonPropertyName("seaLevelPressure")]
    public SeaLevelPressure? seaLevelPressure { get; set; }

    [JsonPropertyName("visibility")]
    public Visibility? visibility { get; set; }

    [JsonPropertyName("maxTemperatureLast24Hours")]
    public MaxTemperatureLast24Hours? maxTemperatureLast24Hours { get; set; }

    [JsonPropertyName("minTemperatureLast24Hours")]
    public MinTemperatureLast24Hours? minTemperatureLast24Hours { get; set; }

    [JsonPropertyName("precipitationLastHour")]
    public PrecipitationLastHour? precipitationLastHour { get; set; }

    [JsonPropertyName("precipitationLast3Hours")]
    public PrecipitationLast3Hours? precipitationLast3Hours { get; set; }

    [JsonPropertyName("precipitationLast6Hours")]
    public PrecipitationLast6Hours? precipitationLast6Hours { get; set; }

    [JsonPropertyName("relativeHumidity")]
    public RelativeHumidity? relativeHumidity { get; set; }

    [JsonPropertyName("windChill")]
    public WindChill? windChill { get; set; }

    [JsonPropertyName("heatIndex")]
    public HeatIndex? heatIndex { get; set; }

    [JsonPropertyName("cloudLayers")]
    public List<CloudLayer>? cloudLayers { get; set; }
}

public class RelativeHumidity
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class SeaLevelPressure
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class Temperature
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class Visibility
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class WindChill
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class WindDirection
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public int? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class WindGust
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public object? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

public class WindSpeed
{
    [JsonPropertyName("unitCode")]
    public string? unitCode { get; set; }

    [JsonPropertyName("value")]
    public double? value { get; set; }

    [JsonPropertyName("qualityControl")]
    public string? qualityControl { get; set; }
}

