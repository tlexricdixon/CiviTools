using CiviTools.Models;
using Microsoft.AspNetCore.Components;
using CiviTools.Components.UI;

namespace CiviTools.Components.UI;

public partial class FormHostBase : ComponentBase
{
    [Parameter] public IEnumerable<ComponentNode> Nodes { get; set; } = Enumerable.Empty<ComponentNode>();


    protected RenderFragment RenderNode(ComponentNode node) => builder =>
    {
        var seq = 0;
        switch (node.Component)
        {
            case UiTextField tf:
                builder.OpenComponent(seq++, typeof(UiTextField));
                builder.AddAttribute(seq++, "Model", tf);
                builder.CloseComponent();
                break;
            case UiSelect sel:
                builder.OpenComponent(seq++, typeof(UiSelect));
                builder.AddAttribute(seq++, "Model", sel);
                builder.CloseComponent();
                break;
            case UiDatePicker dp:
                builder.OpenComponent(seq++, typeof(UiDatePicker));
                builder.AddAttribute(seq++, "Model", dp);
                builder.CloseComponent();
                break;
            case UiGrid grid:
                builder.OpenComponent(seq++, typeof(UiGrid));
                builder.AddAttribute(seq++, "Model", grid);
                builder.CloseComponent();
                break;
            default:
                builder.AddContent(seq++, $"Unsupported: {node.Component.GetType().Name}");
                break;
        }
    };
}
