using Microsoft.AspNetCore.Mvc;
using Modul8_BlazorApp1.Shared;

namespace Modul8_BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private static readonly string[] Locations = new[] // OPG 12.1.1 - Et string-array af bynavne
       {
        "København", "Aarhus", "Odense", "Aalborg", "Esbjerg", "Randers", "Kolding", "Horsens", "Vejle", "Roskilde"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                Location = Locations[Random.Shared.Next(Locations.Length)] // OPG 12.1.1. Vælger en tilfældig af bynavnene i arrayet.
            })
            .ToArray();
        }

        [HttpGet] //OPG 12.1.7 og 8 og 9. Ny get som bruges når vi skal bruge userinput, og bruge tempratur filteret
        [Route("{n:int}")]
        public IEnumerable<WeatherForecast> GetAmount(int n, int minTemp = -20, int maxTemp = 55)
        {
            return Enumerable.Range(1, n).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(minTemp, maxTemp+1),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                Location = Locations[Random.Shared.Next(Locations.Length)]
            })
            .ToArray();
        }
    }
}