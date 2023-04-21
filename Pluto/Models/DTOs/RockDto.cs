using Pluto.Models.Enums;

namespace Pluto.Models.DTOs;

public record RockDto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public RockTypes? Type { get; set; }

    public List<string>? Minerals { get; set; }
}