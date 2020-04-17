using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http;

namespace MickKonradProjectBackend.Controllers
{
    [ApiController]
    [Route("api")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("stop/{stopId}")]
        [Produces("application/json")]
        public IActionResult Get(int stopId)
        {
            using (var client = new WebClient())
            {
                var responseString = client.DownloadString($"https://data.smartdublin.ie/cgi-bin/rtpi/realtimebusinformation?stopid={stopId}&format=json");
                return Content(responseString, "application/json");
            }
            
        }
    }
}