﻿export function afterStarted(Blazor) {
    Blazor.registerCustomEventType("selectionchanged", {
        createEventArgs: event => {
            const args = event.detail.args;
            return {
                isSettingsSelected: args.isSettingsSelected,
                selectedItem: {
                    tag: args.selectedItem.tag,
                    href: args.selectedItem.href
                }
            };
        }
    });
}

window.FluentNavigationViewInterop = {
    navigate: (href, navigation) => navigation.navigate(href)
}