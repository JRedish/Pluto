using Microsoft.AspNetCore.Mvc;
using Pluto.Models.DTOs;
using Pluto.Services;

namespace Pluto.Controllers;

[ApiController]
[Route("[controller]")]
public class MineralController : ControllerBase
{
    private readonly IMineralService _mineralService;

    public MineralController(IMineralService mineralService)
    {
        _mineralService = mineralService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<MineralDto>> GetMinerals()
    {
        return Ok(_mineralService.GetMinerals());
    }

    [HttpGet]
    [Route("/{id}")]
    public ActionResult<MineralDto> GetMineral(string id)
    {
        var mineral = _mineralService.GetMineral(id);
        return mineral == null ? NotFound() : Ok(mineral);
    }
}