using Pluto.Models.Data;
using Pluto.Models.DTOs;

namespace Pluto.Services;

public class MineralService : IMineralService
{
    private readonly List<Mineral> _minerals;

    public MineralService()
    {
        _minerals = new List<Mineral>
        {
            new() { Id = "7B130F45-9899-4913-845D-3B39793AA01D", Name = "Potassium feldspar " },
            new() { Id = "1487FF13-F863-4348-8C4D-F9D70394CE86", Name = "Plagioclase feldspar" },
            new() { Id = "95FC372D-BA91-42E8-9438-0D6207A3E411", Name = "Quartz" },
            new() { Id = "F2F4519F-B58B-4BF6-B6FD-F8E596056FE6", Name = "Muscovite" },
            new() { Id = "4B641070-CF37-44F0-ABDB-7D12D2E1C856", Name = "Chlorite" },
            new() { Id = "CD491457-3D7B-4EBE-899E-DF9D4D3718BB", Name = "Talc" },
            new() { Id = "7ABAFD5F-45AA-4D2A-9ECB-4FB8131E50FE", Name = "Sericite" },
            new() { Id = "301C0F7F-DD0B-4884-A46A-4F415C1293A4", Name = "Biotite" },
            new() { Id = "B3A6A117-42FC-4930-9B6C-7017D93297C2", Name = "Graphite" },
            new() { Id = "00CAC88F-ABE8-47B1-9277-2CA45CAADB74", Name = "Feldspar" }
        };
    }

    public IEnumerable<MineralDto> GetMinerals()
    {
        return _minerals.Select(s => new MineralDto
        {
            Id = s.Id,
            Name = s.Name
        });
    }

    public MineralDto? GetMineral(string id)
    {
        var mineral = _minerals.FirstOrDefault(f => f.Id.ToUpper() == id.ToUpper());

        if (mineral == null) return null;

        return new MineralDto
        {
            Id = mineral.Id,
            Name = mineral.Name,
            ChemicalComposition = null
        };
    }
}