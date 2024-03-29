﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using sagemode_fluent_blazor_components.Utilities.Classes;
using sagemode_fluent_blazor_components.Utilities.Enums;

namespace sagemode_fluent_blazor_components.Components;

public partial class FluentNavigationView : FluentComponentBase
{
    [Inject] public IJSRuntime JsRuntime { get; set; }

    [Parameter]
    public PaneDisplayMode? PaneDisplayMode { get; set; }

    [Parameter]
    public string? Header { get; set; }

    [Parameter]
    public string? PaneTitle { get; set; }

    [Parameter]
    public bool? AlwaysShowHeader { get; set; }

    [Parameter]
    public bool? IsSettingsVisible { get; set; }

    [Parameter]
    public bool? SelectsOnLoad { get; set; }

    [Parameter]
    public HeaderSource? HeaderSrc { get; set; }

    [Parameter]
    public EventCallback<NavigationViewSelectionChangedEventArgs> OnSelectionChanged { get; set; }

    public void Navigate(string href)
    {
        JsRuntime.InvokeVoidAsync("FluentNavigationViewInterop.navigate", href, Element);
    }
}