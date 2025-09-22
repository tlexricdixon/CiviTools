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
    public static IReadOnlyList<PropMeta> DesignPropsStatic()
    {
        object? Get(UiComponentBase c, Func<UiSelect, object?> sel) => sel((UiSelect)c);
        void Set(UiComponentBase c, Action<UiSelect> set) => set((UiSelect)c);

        return new List<PropMeta>
        {
            new("Title", "Label", "string", c => Get(c, s => s.Title), (c, v) => Set(c, s => s.Title = v?.ToString() ?? "")),
            new("Items", "Items (comma‑sep)", "string", c => Get(c, s => string.Join(",", s.Items)), (c, v) => Set(c, s => s.Items = (v?.ToString() ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList())),
            new("Cols", "Width (1-12)", "int", c => Get(c, s => s.Cols), (c, v) => Set(c, s => s.Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i, 1, 12) : 12)),
            new("CssClass", "CSS class", "string", c => Get(c, s => s.CssClass), (c, v) => Set(c, s => s.CssClass = v?.ToString() ?? ""))
        };
    }
}
public static class UiGridExtensions
{
    public static IReadOnlyList<PropMeta> DesignPropsStatic()
    {
        object? Get(UiComponentBase c, Func<UiGrid, object?> sel) => sel((UiGrid)c);
        void Set(UiComponentBase c, Action<UiGrid> set) => set((UiGrid)c);

        return new List<PropMeta>
        {
            new("Title", "Label", "string", c => Get(c, g => g.Title), (c, v) => Set(c, g => g.Title = v?.ToString() ?? "")),
            new("Cols", "Width (1-12)", "int", c => Get(c, g => g.Cols), (c, v) => Set(c, g => g.Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i, 1, 12) : 12)),
            new("CssClass", "CSS class", "string", c => Get(c, g => g.CssClass), (c, v) => Set(c, g => g.CssClass = v?.ToString() ?? ""))
        };
    }
}
public static class UiDatePickerExtensions
{
    public static IReadOnlyList<PropMeta> DesignPropsStatic()
    {
        object? Get(UiComponentBase c, Func<UiDatePicker, object?> sel) => sel((UiDatePicker)c);
        void Set(UiComponentBase c, Action<UiDatePicker> set) => set((UiDatePicker)c);

        return new List<PropMeta>
        {
            new("Title", "Label", "string", c => Get(c, d => d.Title), (c, v) => Set(c, d => d.Title = v?.ToString() ?? "")),
            new("Cols", "Width (1-12)", "int", c => Get(c, d => d.Cols), (c, v) => Set(c, d => d.Cols = int.TryParse(v?.ToString(), out var i) ? Math.Clamp(i, 1, 12) : 12)),
            new("CssClass", "CSS class", "string", c => Get(c, d => d.CssClass), (c, v) => Set(c, d => d.CssClass = v?.ToString() ?? ""))
        };
    }
}
