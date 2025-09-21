using CiviTools.Models;
using Microsoft.AspNetCore.Components;

namespace CiviTools.Components.UI;

public partial class FormHostBase : ComponentBase
{
    [Parameter] public IEnumerable<ComponentNode> Nodes { get; set; } = Enumerable.Empty<ComponentNode>();


    protected static RenderFragment RenderNode(ComponentNode node) => builder =>
    {
        switch (node.Component)
        {
            case Models.UiTextField tf:
                builder.OpenComponent(0, typeof(UiTextField));
                builder.AddAttribute(1, "Model", tf);
                builder.CloseComponent();
                break;
            case Models.UiSelect sel:
                builder.OpenComponent(0, typeof(UiSelect));
                builder.AddAttribute(1, "Model", sel);
                builder.CloseComponent();
                break;
            case Models.UiDatePicker dp:
                builder.OpenComponent(0, typeof(UiDatePicker));
                builder.AddAttribute(1, "Model", dp);
                builder.CloseComponent();
                break;
            case Models.UiGrid grid:
                builder.OpenComponent(0, typeof(UiGrid));
                builder.AddAttribute(1, "Model", grid);
                builder.CloseComponent();
                break;
            default:
                builder.AddContent(0, $"Unsupported: {node.Component.GetType().Name}");
                break;
        }
    };
}
