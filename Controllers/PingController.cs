using Microsoft.AspNetCore.Mvc;

namespace dotnet6.Controllers;

[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public PingController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
       return "Server is Healthy";
    }
}
