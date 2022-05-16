using Microsoft.AspNetCore.Components;
using sagemode_fluent_blazor_components.Utilities.Classes;

namespace sagemode_fluent_blazor_components.Components
{
    public partial class FluentImageIcon : FluentComponentBase
    {
        [Parameter] public string? Source { get; set; }

        [Parameter] public int? Size { get; set; }
    }
}