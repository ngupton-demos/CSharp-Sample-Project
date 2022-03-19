namespace NG.CS.SampleWebApi.Application.Convert;

public static class TemperatureConverter
{
    public enum TemperatureType
    {
        Fahrenheit = 'F',
        Celcius = 'C',
        Kelvin = 'K'
    }

    public static double Convert(TemperatureType from, TemperatureType to, double inputTemperature)
    {
        // Step 1, Convert to C
        double inputTempC = from switch
        {
            TemperatureType.Fahrenheit =>
                (inputTemperature - 32.0) * (5.0/ 9.0),
            TemperatureType.Kelvin =>
                inputTemperature - 273.15,
            _ => inputTemperature
        };

        // Step 2, Convert to requested type
        return to switch
        {
            TemperatureType.Fahrenheit =>
                (inputTempC * (9.0 / 5.0)) + 32.0,
            TemperatureType.Kelvin =>
                inputTempC + 273.15,
            _ => inputTempC
        };
    }
}