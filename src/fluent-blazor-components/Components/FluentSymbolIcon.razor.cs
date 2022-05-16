using Microsoft.AspNetCore.Components;

namespace sagemode_fluent_blazor_components.Components
{
    public partial class FluentSymbolIcon : FluentFontIcon
    {
        [Parameter] public string? Symbol { get; set; }
    }
}