using Microsoft.AspNetCore.Components;
using sagemode_fluent_blazor_components.Utilities.Classes;
using sagemode_fluent_blazor_components.Utilities.Enums;

namespace sagemode_fluent_blazor_components.Components;

public partial class FluentNavigationView : FluentComponentBase
{
    [Parameter]
    public PaneDisplayMode? PaneDisplayMode { get; set; }

    [Parameter]
    public IEnumerable<IconSet>? IconSets { get; set; }

    [Parameter]
    public string? Header { get; set; }

    [Parameter]
    public string? PaneTitle { get; set; }

    [Parameter]
    public bool? AlwaysShowHeader { get; set; }

    [Parameter]
    public bool? IsSettingsVisible { get; set; }

    [Parameter]
    public EventCallback<NavigationViewSelectionChangedEventArgs> OnSelectionChanged { get; set; }
}