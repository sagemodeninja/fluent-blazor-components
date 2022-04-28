using System.Text.Json.Serialization;

namespace sagemode_fluent_blazor_components.Utilities.Classes;

public class IconSet
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("glyph")]
    public string Glyph { get; set; }
}