using CiviTools.Models;
using Microsoft.AspNetCore.Components;

namespace CiviTools.Components.UI;

public partial class UiSelect
{
    public List<string> Items { get; set; } = new();
}


public class UiSelectBase : ComponentBase
{
    [Parameter] public UiSelect Model { get; set; } = new();


    protected string Title => Model.Title;
    protected List<string> Items => Model.Items;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;


    protected string? Selected { get; set; }
}


public static class UiSelectExtensions
{
    public static IEnumerable<PropMeta> DesignProps(this UiSelect _)
    {
        yield return new PropMeta("Title", "Label", "string", c => ((UiSelect)c).Title, (c, v) => ((UiSelect)c).Title = v?.ToString() ?? "");
        yield return new PropMeta("Items", "Items (comma‑sep)", "string", c => string.Join(",", ((UiSelect)c).Items), (c, v) => ((UiSelect)c).Items = (v?.ToString() ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList());
        yield return new PropMeta("Cols", "Width (1-12)", "int", c => ((UiSelect)c).Cols, (c, v) => ((UiSelect)c).Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i, 1, 12) : 12);
        yield return new PropMeta("CssClass", "CSS class", "string", c => ((UiSelect)c).CssClass, (c, v) => ((UiSelect)c).CssClass = v?.ToString() ?? "");
    }
}
