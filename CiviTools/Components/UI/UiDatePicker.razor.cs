using CiviTools.Models;
using Microsoft.AspNetCore.Components;

namespace CiviTools.Components.UI;

public partial class UiDatePicker : UiComponentBase { }


public class UiDatePickerBase : ComponentBase
{
    [Parameter] public UiDatePicker Model { get; set; } = new();


    protected string Title => Model.Title;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;


    protected DateTime? Value { get; set; }
}


public static class UiDatePickerExtensions
{
    public static IEnumerable<PropMeta> DesignProps(this UiDatePicker _)
    {
        yield return new PropMeta("Title", "Label", "string", c => ((UiDatePicker)c).Title, (c, v) => ((UiDatePicker)c).Title = v?.ToString() ?? "");
        yield return new PropMeta("Cols", "Width (1-12)", "int", c => ((UiDatePicker)c).Cols, (c, v) => ((UiDatePicker)c).Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i, 1, 12) : 12);
        yield return new PropMeta("CssClass", "CSS class", "string", c => ((UiDatePicker)c).CssClass, (c, v) => ((UiDatePicker)c).CssClass = v?.ToString() ?? "");
    }
}
