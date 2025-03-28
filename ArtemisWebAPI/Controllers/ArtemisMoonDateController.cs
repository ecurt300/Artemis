using Microsoft.AspNetCore.Mvc;

namespace ArtemisWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtemisMoonDateController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "PartialMoon","FirstQuaterMoon", "FullMoon"
        };

        private readonly ILogger<ArtemisMoonDateController> _logger;

        public ArtemisMoonDateController(ILogger<ArtemisMoonDateController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast/{date}")]
        public IEnumerable<MoonDate> Get(DateTime date)
        {
            return Enumerable.Range(1, 5).Select(index => new MoonDate
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Days = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
