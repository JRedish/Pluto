using Microsoft.AspNetCore.Mvc;
using Pluto.Models.DTOs;
using Pluto.Services;

namespace Pluto.Controllers;

[ApiController]
[Route("[controller]")]
public class RockController : ControllerBase
{
    private readonly IRockService _rockService;

    public RockController(IRockService rockService)
    {
        _rockService = rockService;
    }

    [HttpGet]
    public ActionResult<List<RockDto>> GetRocks()
    {
        return Ok(_rockService.GetRocks());
    }

    [HttpGet]
    [Route("id")]
    public ActionResult<RockDto> GetRock(string id)
    {
        var rock = _rockService.GetRock(id);
        return rock == null ? NotFound() : Ok(rock);
    }
}