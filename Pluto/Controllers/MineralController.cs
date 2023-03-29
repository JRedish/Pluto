using Microsoft.AspNetCore.Mvc;
using Pluto.Services;

namespace Pluto.Controllers;

[ApiController]
[Route("[controller]")]
public class MineralController : ControllerBase
{
    private readonly IMineralService _mineralService;
    public MineralController(IMineralService mineralService) { 
        _mineralService = mineralService;
    }

    [HttpGet]
    public OkObjectResult Get(string name)
    {
        return new OkObjectResult(new { Message=_mineralService.GetMineral(name) });
    }
}