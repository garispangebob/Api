using System.Drawing;
using Newtonsoft.Json;

namespace Api.Core.DTOs.IikoDTOs;

public class ProductDto
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("deleted")] public bool Deleted { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("description")] public string Description { get; set; }

    [JsonProperty("num")] public string Num { get; set; }

    [JsonProperty("code")] public string Code { get; set; }

    [JsonProperty("parent")] public object Parent { get; set; }

    [JsonProperty("modifiers")] public List<ChildModifierDto> Modifiers { get; set; }

    [JsonProperty("taxCategory")] public object TaxCategory { get; set; }

    [JsonProperty("category")] public object Category { get; set; }

    [JsonProperty("accountingCategory")] public string AccountingCategory { get; set; }

    [JsonProperty("color")] public Color Color { get; set; }

    [JsonProperty("fontColor")] public FontColorDto FontColor { get; set; }

    [JsonProperty("frontImageId")] public object FrontImageId { get; set; }

    [JsonProperty("position")] public object Position { get; set; }

    [JsonProperty("mainUnit")] public string MainUnit { get; set; }

    [JsonProperty("excludedSections")] public object ExcludedSections { get; set; }

    [JsonProperty("defaultSalePrice")] public int DefaultSalePrice { get; set; }

    [JsonProperty("placeType")] public object PlaceType { get; set; }

    [JsonProperty("defaultIncludedInMenu")]
    public bool DefaultIncludedInMenu { get; set; }

    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("unitWeight")] public double UnitWeight { get; set; }

    [JsonProperty("unitCapacity")] public int UnitCapacity { get; set; }

    [JsonProperty("notInStoreMovement")] public bool NotInStoreMovement { get; set; }
}
