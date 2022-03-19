using Microsoft.AspNetCore.Mvc;
using NG.CS.SampleWebApi.Application;
using NG.CS.SampleWebApi.Application.Model;

namespace NG.CS.SampleWebApi.Controllers.Weather;

[ApiController]
public class RandomForecastController : ControllerBase
{
    [Route("api/Weather/RandomForecast/{numberOfDays}")]
    [HttpGet]
    public IEnumerable<WeatherForecast> Get(int numberOfDays)
    {
        return RandomForecastGenerator.Generate(numberOfDays);
    }
}