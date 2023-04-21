namespace Pluto.Models.DTOs;

public record MineralDto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? ChemicalComposition { get; set; }
}