using CiviTools.Models;
namespace CiviTools.Models.Extentions;

public static class UIExtentions
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
public static class UiGridExtensions
{
    public static IEnumerable<PropMeta> DesignProps(this UiGrid _)
    {
        yield return new PropMeta("Title", "Label", "string", c => ((UiGrid)c).Title, (c, v) => ((UiGrid)c).Title = v?.ToString() ?? "");
        yield return new PropMeta("Cols", "Width (1-12)", "int", c => ((UiGrid)c).Cols, (c, v) => ((UiGrid)c).Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i, 1, 12) : 12);
        yield return new PropMeta("CssClass", "CSS class", "string", c => ((UiGrid)c).CssClass, (c, v) => ((UiGrid)c).CssClass = v?.ToString() ?? "");
    }
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
