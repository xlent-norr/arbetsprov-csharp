using Microsoft.AspNetCore.Mvc;

namespace Arbetsprov.CSharp.Web.Controllers;

[Route("api/weather")]
public class WeatherApiController : Controller
{
    public IActionResult Get()
    {
        return Ok(new { Fake = true });
    }
}