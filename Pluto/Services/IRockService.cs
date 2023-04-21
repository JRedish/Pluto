using Pluto.Models.DTOs;

namespace Pluto.Services;

public interface IRockService
{
    List<RockDto> GetRocks();

    RockDto? GetRock(string name);
}