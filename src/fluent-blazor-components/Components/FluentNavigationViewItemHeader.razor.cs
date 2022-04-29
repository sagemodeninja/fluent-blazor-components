using Microsoft.AspNetCore.Components;
using sagemode_fluent_blazor_components.Utilities.Classes;

namespace sagemode_fluent_blazor_components.Components;

public partial class FluentNavigationViewItemHeader : FluentComponentBase
{
    [Parameter]
    public string? Content { get; set; }
}