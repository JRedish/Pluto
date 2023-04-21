using Pluto.Models.DTOs;

namespace Pluto.Services;

public interface IMineralService
{
    IEnumerable<MineralDto> GetMinerals();

    MineralDto? GetMineral(string id);
}