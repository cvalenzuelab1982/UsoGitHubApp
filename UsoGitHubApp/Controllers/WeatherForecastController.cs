using Microsoft.AspNetCore.Mvc;

namespace UsoGitHubApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hola mundo primer cambio");
        }
    }
}