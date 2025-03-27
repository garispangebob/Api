using Newtonsoft.Json;

namespace Api.Core.DTOs.IikoDTOs;

public class ChildModifierDto
{
    [JsonProperty("modifier")] public string Modifier { get; set; }

    [JsonProperty("defaultAmount")] public int DefaultAmount { get; set; }

    [JsonProperty("freeOfChargeAmount")] public int FreeOfChargeAmount { get; set; }

    [JsonProperty("minimumAmount")] public int MinimumAmount { get; set; }

    [JsonProperty("maximumAmount")] public int MaximumAmount { get; set; }

    [JsonProperty("hideIfDefaultAmount")] public bool HideIfDefaultAmount { get; set; }

    [JsonProperty("required")] public bool Required { get; set; }

    [JsonProperty("childModifiersHaveMinMaxRestrictions")]
    public bool ChildModifiersHaveMinMaxRestrictions { get; set; }

    [JsonProperty("splittable")] public bool Splittable { get; set; }

    [JsonProperty("childModifiers")] public ChildModifierDto ChildModifiers { get; set; }
}