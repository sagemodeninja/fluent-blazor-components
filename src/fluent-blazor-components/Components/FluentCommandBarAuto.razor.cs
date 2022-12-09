using System;
using Microsoft.AspNetCore.Components;
using sagemode_fluent_blazor_components.Utilities.Classes;
using sagemode_fluent_blazor_components.Utilities.Enums;

namespace sagemode_fluent_blazor_components.Components
{
    /// <summary>
    /// A variant of FluentCommandBar with templating.
    /// </summary>
    public partial class FluentCommandBarAuto<TItem> : FluentComponentBase
    {
        [Parameter] public RenderFragment<TItem>? ItemTemplate { get; set; }

        [Parameter] public IEnumerable<TItem>? Items { get; set; }

        [Parameter] public CommandBarAppearance? DefaultLabelPosition { get; set; }

        [Parameter] public bool? IsOpen { get; set; }

        [Parameter] public bool? CustomMenu { get; set; }

        [Parameter]
        public EventCallback<EventArgs> OnMenuInvoked { get; set; }

        [Parameter]
        public EventCallback<CommandBarCommandMovedEventArgs> OnCommandMoved { get; set; }
    }
}

