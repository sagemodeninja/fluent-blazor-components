using Microsoft.AspNetCore.Components;

namespace sagemode_fluent_blazor_components;

public abstract class FluentComponentBase : ComponentBase
{
    public ElementReference Element { get; set; }

    /// <summary>
    /// Gets or sets the content to be rendered inside the component
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)] public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
}