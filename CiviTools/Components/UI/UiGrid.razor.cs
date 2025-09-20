using CiviTools.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using System.Reflection;
namespace CiviTools.Components.UI;

public partial class UiGrid : UiComponentBase
{
    // Simple demo dataset to show the grid without wiring data connectors yet
    public IEnumerable<object> Rows { get; set; } = new List<object>
{
new { Id=1, Name="Alice", Email="alice@example.com" },
new { Id=2, Name="Bob", Email="bob@example.com" },
new { Id=3, Name="Charlie", Email="charlie@example.com" },
};
}


public class UiGridBase : ComponentBase
{
    [Parameter] public UiGrid Model { get; set; } = new();


    protected string Title => Model.Title;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;


    protected IEnumerable<object> Rows => Model.Rows;


    protected IEnumerable<PropertyInfo> Columns => Rows.FirstOrDefault()?.GetType().GetProperties() ?? Array.Empty<PropertyInfo>();
}


public static class UiGridExtensions
{
    public static IEnumerable<PropMeta> DesignProps(this UiGrid _)
    {
        yield return new PropMeta("Title", "Label", "string", c => ((UiGrid)c).Title, (c, v) => ((UiGrid)c).Title = v?.ToString() ?? "");
        yield return new PropMeta("Cols", "Width (1-12)", "int", c => ((UiGrid)c).Cols, (c, v) => ((UiGrid)c).Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i, 1, 12) : 12);
        yield return new PropMeta("CssClass", "CSS class", "string", c => ((UiGrid)c).CssClass, (c, v) => ((UiGrid)c).CssClass = v?.ToString() ?? "");
    }
}
