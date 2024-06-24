
using NwsApi.Models;

namespace NwsApi.Helpers;

public static class Complex
{
    public static double GetFeelsLikeTemperature(Observations observations)
    {
        double? heatindex = observations.properties?.heatIndex?.value;
        double? windchill = observations.properties?.windChill?.value;

        if (heatindex is not null)
            return heatindex ?? -999;

        if (windchill is not null)
            return windchill ?? -999;

        return -999;
    }
}