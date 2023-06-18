using Microsoft.AspNetCore.Mvc;
using MyApiWithKey.Authentication;

namespace MyApiWithKey.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        [ServiceFilter(typeof(ApiKeyAuthFilter))]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[HttpPost(Name = "PostWeatherForecast")]
        //public ActionResult WeatherForecasts(int? temperatureC, int? temperatureF, string? summary, int? part)
        //{
        //    var toto = temperatureF;

        //    return Ok();

        //}

        [HttpPost(Name = "PostWeatherForecast")]
        public ActionResult WeatherForecasts([FromBody] MiniForecast miniForecast)
        {
            var toto = miniForecast.TemperatureF;

            return Ok();

        }


    }
}