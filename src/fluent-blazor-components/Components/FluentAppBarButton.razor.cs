using Microsoft.AspNetCore.Components;
using sagemode_fluent_blazor_components.Utilities.Classes;
using sagemode_fluent_blazor_components.Utilities.Enums;

namespace sagemode_fluent_blazor_components.Components
{
    public partial class FluentAppBarButton : FluentComponentBase
    {
        [Parameter] public string? Icon { get; set; }

        [Parameter] public string? Label { get; set; }

        [Parameter] public string? Command { get; set; }

        [Parameter] public CommandBarAppearance? Appearance { get; set; }

        [Parameter] public string? Modifier { get; set; }

        [Parameter] public string? Key { get; set; }
    }
}