using FluentAssertions;
using NG.CS.SampleWebApi.Application.Convert;
using Xunit;

namespace NG.CS.SampleWebApi.Application.Test.Convert
{
    
    public static class TemperatureConverterShould
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(-40, -40)]
        [InlineData(212, 100)]
        public static void ConvertFtoC(double inputTemp, double expectedOutput)
        {
            var from = TemperatureConverter.TemperatureType.Fahrenheit;
            var to = TemperatureConverter.TemperatureType.Celcius;

            TemperatureConverter.Convert(from, to, inputTemp)
                .Should().BeApproximately(expectedOutput, 0.001);
        }

        [Theory]
        [InlineData(0, 32)]
        [InlineData(-40, -40)]
        [InlineData(100, 212)]
        public static void ConvertCtoF(double inputTemp, double expectedOutput)
        {
            var from = TemperatureConverter.TemperatureType.Celcius;
            var to = TemperatureConverter.TemperatureType.Fahrenheit;

            TemperatureConverter.Convert(from, to, inputTemp)
                .Should().BeApproximately(expectedOutput, 0.001);
        }

        [Theory]
        [InlineData(-273.15, 0)]
        [InlineData(100, 373.15)]
        [InlineData(1000, 1273.15)]
        public static void ConvertCtoK(double inputTemp, double expectedOutput)
        {
            var from = TemperatureConverter.TemperatureType.Celcius;
            var to = TemperatureConverter.TemperatureType.Kelvin;

            TemperatureConverter.Convert(from, to, inputTemp)
                .Should().BeApproximately(expectedOutput, 0.001);
        }

        [Theory]
        [InlineData(0, -459.67)]
        [InlineData(100, -279.67)]
        [InlineData(1000, 1340.33)]
        public static void ConvertKtoF(double inputTemp, double expectedOutput)
        {
            var from = TemperatureConverter.TemperatureType.Kelvin;
            var to = TemperatureConverter.TemperatureType.Fahrenheit;

            TemperatureConverter.Convert(from, to, inputTemp)
                .Should().BeApproximately(expectedOutput, 0.001);
        }
    }
}
