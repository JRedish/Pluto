using Microsoft.AspNetCore.Mvc;

namespace Pluto.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    public HealthController() { }

    [HttpGet]
    public OkObjectResult IsAlive()
    {
        return new OkObjectResult(new { Message = "I'm still alive!" });
    }
}