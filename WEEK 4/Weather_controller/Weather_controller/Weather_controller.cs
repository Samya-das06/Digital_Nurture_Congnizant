using Microsoft.AspNetCore.Mvc;

namespace ConsoleWebApiApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var forecast = new[]
        {
            "Sunny", "Cloudy", "Rainy", "Windy"
        };
        return Ok(forecast);
    }
}
