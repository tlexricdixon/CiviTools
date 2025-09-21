using CiviTools.Models;
namespace CiviTools.Models.Extentions;

public static class UiTextFieldExtensions
{
    public static IReadOnlyList<PropMeta> DesignPropsStatic()
    {
        object? Get(UiComponentBase c, Func<UiTextField, object?> sel) => sel((UiTextField)c);
        void Set(UiComponentBase c, Action<UiTextField> set) => set((UiTextField)c);

        return new List<PropMeta>
        {
            new("Title","Label","string", c => Get(c,t=>t.Title),        (c,v)=>Set(c,t=>t.Title = v?.ToString() ?? "")),
            new("Placeholder","Placeholder","string", c => Get(c,t=>t.Placeholder),(c,v)=>Set(c,t=>t.Placeholder = v?.ToString() ?? "")),
            new("Help","Help text","string", c => Get(c,t=>t.Help),       (c,v)=>Set(c,t=>t.Help = v?.ToString() ?? "")),
            new("Cols","Width (1-12)","int", c => Get(c,t=>t.Cols),       (c,v)=>Set(c,t=>t.Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i,1,12) : 12)),
            new("CssClass","CSS class","string", c => Get(c,t=>t.CssClass),(c,v)=>Set(c,t=>t.CssClass = v?.ToString() ?? "")),
            new("InitialValue","Initial value","string", c=>Get(c,t=>t.InitialValue ?? ""), (c,v)=>Set(c,t=>t.InitialValue = v?.ToString()))
        };
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
