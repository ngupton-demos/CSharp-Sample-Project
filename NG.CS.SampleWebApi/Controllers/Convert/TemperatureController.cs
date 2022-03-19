using Microsoft.AspNetCore.Mvc;
using NG.CS.SampleWebApi.Application.Convert;

namespace NG.CS.SampleWebApi.Controllers.Convert;

[ApiController]
public class TemperatureController : ControllerBase
{
    [Route("api/Convert/Temperature/{temp}/{from}/to/{to}")]
    [HttpGet]
    public double ConvertTemp(double temp, char from, char to)
    {
        if (from != 'F' && from != 'C' && from != 'K')
        {
            throw new ArgumentException("Invalid temperature type provided. 'F', 'C', or 'K' are valid choices.", nameof(from));
        }

        if (to != 'F' && to != 'C' && to != 'K')
        {
            throw new ArgumentException("Invalid temperature type provided. 'F', 'C', or 'K' are valid choices.", nameof(to));
        }

        var fromType = (TemperatureConverter.TemperatureType) from;
        var toType = (TemperatureConverter.TemperatureType) to;

        return TemperatureConverter.Convert(fromType, toType, temp);
    }
}