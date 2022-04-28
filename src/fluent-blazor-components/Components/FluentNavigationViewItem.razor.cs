using Microsoft.AspNetCore.Components;

namespace sagemode_fluent_blazor_components.Components;

public partial class FluentNavigationViewItem : FluentComponentBase
{
    [Parameter]
    public string? Icon { get; set; }

    [Parameter]
    public string? Content { get; set; }

    [Parameter]
    public string? Tag { get; set; }

    [Parameter]
    public bool? SelectsOnInvoke { get; set; }
}