using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers;

[ApiController]
[Route("Client")]
public class WeatherForecastController : ControllerBase
{

    [HttpGet(Name = "TryGet")]
    public async Task<string> Get()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("http://localhost:5089/server/HelloWorld");
        var readAsStringAsync = await response.Content.ReadAsStringAsync();
        return readAsStringAsync;
    }
}