using Microsoft.AspNetCore.Components;
using sagemode_fluent_blazor_components.Utilities.Classes;

namespace sagemode_fluent_blazor_components.Components
{
    public partial class FluentFontIcon : FluentComponentBase
    {
        [Parameter] public string? FontFamily { get; set; }

        [Parameter] public string? Glyph { get; set; }

        [Parameter] public int? FontSize { get; set; }

        [Parameter] public string? Foreground { get; set; }
    }
}
