﻿using Microsoft.AspNetCore.Components;

namespace sagemode_fluent_blazor_components.Utilities.Classes;

public class NavigationViewSelectionChangedEventArgs : EventArgs
{
    public bool IsSettingsSelected { get; set; }

    public SelectedItem SelectedItem { get; set; }
}

public class CommandBarCommandMovedEventArgs : EventArgs
{
    public string? Type { get; set; }

    public string? Command { get; set; }

    public bool Collapsed { get; set; }
}

[EventHandler("onselectionchanged", typeof(NavigationViewSelectionChangedEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("onmenuinvoked", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("oncommandmoved", typeof(CommandBarCommandMovedEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
public static class EventHandlers { }