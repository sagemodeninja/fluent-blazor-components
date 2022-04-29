using Microsoft.AspNetCore.Components;

namespace sagemode_fluent_blazor_components.Utilities.Classes;

public class NavigationViewSelectionChangedEventArgs : EventArgs
{
    public bool IsSettingsSelected { get; set; }

    public SelectedItem SelectedItem { get; set; }
}

[EventHandler("onselectionchanged", typeof(NavigationViewSelectionChangedEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
public static class EventHandlers
{
}