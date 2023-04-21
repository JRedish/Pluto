using Pluto.Models.Data;
using Pluto.Models.DTOs;
using Pluto.Models.Enums;

namespace Pluto.Services;

public class RockService : IRockService
{
    private readonly List<Rock> _rocks;

    public RockService()
    {
        _rocks = new List<Rock>
        {
            new() { Id = "CE9237D8-6138-4B7C-9A4D-406B2FA88BE8", Name = "Granite", Type = RockTypes.IGNEOUS },
            new() { Id = "3FE6BE30-AAC3-4AD3-97B2-09E9968FB5E8", Name = "Sandstone", Type = RockTypes.SEDIMENTARY },
            new() { Id = "E78E5B67-9624-430E-BBB4-1BB78585DBAB", Name = "Schist", Type = RockTypes.METAMORPHIC }
        };
    }

    public List<RockDto> GetRocks()
    {
        return _rocks.Select(f => new RockDto
        {
            Id = f.Id,
            Name = f.Name,
            Type = f.Type,
            Minerals = f.Minerals
        }).ToList();
    }

    public RockDto? GetRock(string id)
    {
        var rock = _rocks.FirstOrDefault(f => f.Id.ToUpper() == id.ToUpper());

        if (rock == null) return null;

        return new RockDto
        {
            Id = rock.Id,
            Name = rock.Name,
            Type = rock.Type,
            Minerals = rock.Minerals
        };
    }
}