using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Arbetsprov.CSharp.Web.Models;
using System.Threading.Tasks;

namespace Arbetsprov.CSharp.Web.Controllers
{
    [Route("api/weather")]
    public class WeatherApiController : Controller
    {
        private readonly ILogger<WeatherApiController> _logger;

        public WeatherApiController(ILogger<WeatherApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetWeatherDataAsync([FromQuery] double latitude, [FromQuery] double longitude)
        {
            var result = new WeatherData();
            return Ok(result);
        }
    }
}
