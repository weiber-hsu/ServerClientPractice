using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("Server")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    [Route("HelloWorld")]
    public string GetHelloWorld()
    {
        return "Hello World";
    }
}