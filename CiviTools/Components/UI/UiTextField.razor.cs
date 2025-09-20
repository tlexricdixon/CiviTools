using CiviTools.Models;
using Microsoft.AspNetCore.Components;

namespace CiviTools.Components.UI;

public partial class UiTextField : UiComponentBase
{
    public string Placeholder { get; set; } = string.Empty;
    public string Help { get; set; } = string.Empty;
}
public class UiTextFieldBase : ComponentBase
{
    [Parameter] public UiTextField Model { get; set; } = new();


    // convenience passthroughs for markup
    protected string Title => Model.Title;
    protected string Placeholder => Model.Placeholder;
    protected string Help => Model.Help;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;


    protected string? Value { get; set; }
}


public static class UiTextFieldExtensions
{
    public static IEnumerable<PropMeta> DesignProps(this UiTextField _)
    {
        yield return new PropMeta("Title", "Label", "string", c => ((UiTextField)c).Title, (c, v) => ((UiTextField)c).Title = v?.ToString() ?? "");
        yield return new PropMeta("Placeholder", "Placeholder", "string", c => ((UiTextField)c).Placeholder, (c, v) => ((UiTextField)c).Placeholder = v?.ToString() ?? "");
        yield return new PropMeta("Help", "Help text", "string", c => ((UiTextField)c).Help, (c, v) => ((UiTextField)c).Help = v?.ToString() ?? "");
        yield return new PropMeta("Cols", "Width (1-12)", "int", c => ((UiTextField)c).Cols, (c, v) => ((UiTextField)c).Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i, 1, 12) : 12);
        yield return new PropMeta("CssClass", "CSS class", "string", c => ((UiTextField)c).CssClass, (c, v) => ((UiTextField)c).CssClass = v?.ToString() ?? "");
    }
}
