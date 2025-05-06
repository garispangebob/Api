using Api.Core.Entities;

namespace Api.Core.DTOs;

public class DraftProductDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Tap? Tap { get; set; }
}