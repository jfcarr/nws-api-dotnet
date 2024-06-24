namespace NwsApi.Helpers;

public static class Conversions
{
    public static double CelsiusToFahrenheit(double celsiusValue)
    {
        return ((celsiusValue * (9.0 / 5.0)) + 32.0);
    }
}
