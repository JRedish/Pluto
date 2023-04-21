using Pluto.Models.Enums;

namespace Pluto.Models.Data;

public record Rock
{
    public required string Id { get; set; }

    public required string Name { get; set; }

    public RockTypes? Type { get; set; }

    public List<string> Minerals { get; set; } = new();
}