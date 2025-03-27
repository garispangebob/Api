using Newtonsoft.Json;

namespace Api.Core.DTOs.IikoDTOs;

public class FontColorDto
{
    [JsonProperty("red")] public int Red { get; set; }

    [JsonProperty("green")] public int Green { get; set; }

    [JsonProperty("blue")] public int Blue { get; set; }
}