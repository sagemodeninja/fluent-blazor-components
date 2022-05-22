using Microsoft.AspNetCore.Components;
using sagemode_fluent_blazor_components.Utilities.Classes;
using sagemode_fluent_blazor_components.Utilities.Enums;

namespace sagemode_fluent_blazor_components.Components
{
    public partial class FluentCommandBar : FluentComponentBase
    {
        [Parameter] public CommandBarAppearance? DefaultLabelPosition { get; set; }

        [Parameter] public bool? IsOpen { get; set; }
    }
}
