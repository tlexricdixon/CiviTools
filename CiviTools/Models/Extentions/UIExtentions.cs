namespace CiviTools.Models.Extentions;

using System;
using System.Collections.Generic;
//public static class UiTextFieldExtensions
//{
//    public static IReadOnlyList<PropMeta> DesignPropsStatic()
//    {
//        object? Get(IDictionary<string, object?> bag, string key, object? fallback = null)
//            => bag.TryGetValue(key, out var v) ? v : fallback;

//        void Set(IDictionary<string, object?> bag, string key, object? value)
//            => bag[key] = value;

//        return new List<PropMeta>
//            {
//                new("Title","Label","string",
//                    c => Get(c.Params, "Title", "Text"),
//                    (c,v)=> Set(c.Params, "Title", v?.ToString() ?? "Text")),

//                new("Placeholder","Placeholder","string",
//                    c => Get(c.Params, "Placeholder", string.Empty),
//                    (c,v)=> Set(c.Params, "Placeholder", v?.ToString() ?? string.Empty)),

//                new("Help","Help text","string",
//                    c => Get(c.Params, "Help", string.Empty),
//                    (c,v)=> Set(c.Params, "Help", v?.ToString() ?? string.Empty)),

//                new("Cols","Width (1-12)","int",
//                    c => Get(c.Params, "Cols", 1),
//                    (c,v)=> {
//                        var s = v?.ToString();
//                        var ok = int.TryParse(s, out var i);
//                        Set(c.Params, "Cols", ok ? Math.Clamp(i, 1, 12) : 1);
//                    }),

//                new("CssClass","CSS class","string",
//                    c => Get(c.Params, "CssClass", string.Empty),
//                    (c,v)=> Set(c.Params, "CssClass", v?.ToString() ?? string.Empty)),

//                // Optional initial content for text fields
//                new("Value","Initial value","string",
//                    c => Get(c.Params, "Value", string.Empty),
//                    (c,v)=> Set(c.Params, "Value", v?.ToString() ?? string.Empty)),
//            };
//    }
//}

//public static class UiSelectExtensions
//{
//    public static IReadOnlyList<PropMeta> DesignPropsStatic()
//    {
//        object? Get(IDictionary<string, object?> bag, string key, object? fallback = null)
//            => bag.TryGetValue(key, out var v) ? v : fallback;

//        void Set(IDictionary<string, object?> bag, string key, object? value)
//            => bag[key] = value;

//        IEnumerable<string> GetItems(object? v) =>
//            v is IEnumerable<string> seq ? seq :
//            v is string s && !string.IsNullOrWhiteSpace(s)
//                ? s.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
//                : Array.Empty<string>();

//        return new List<PropMeta>
//            {
//                new("Title","Label","string",
//                    c => Get(c.Params, "Title", "Select"),
//                    (c,v)=> Set(c.Params, "Title", v?.ToString() ?? "Select")),

//                new("Items","Items (comma-sep)","string",
//                    c => string.Join(",", GetItems(Get(c.Params, "Items"))),
//                    (c,v)=> Set(c.Params, "Items", GetItems(v))),

//                new("Cols","Width (1-12)","int",
//                    c => Get(c.Params, "Cols", 1),
//                    (c,v)=> {
//                        var s = v?.ToString();
//                        var ok = int.TryParse(s, out var i);
//                        Set(c.Params, "Cols", ok ? Math.Clamp(i, 1, 12) : 1);
//                    }),

//                new("CssClass","CSS class","string",
//                    c => Get(c.Params, "CssClass", string.Empty),
//                    (c,v)=> Set(c.Params, "CssClass", v?.ToString() ?? string.Empty)),

//                new("Value","Selected value","string",
//                    c => Get(c.Params, "Value", string.Empty),
//                    (c,v)=> Set(c.Params, "Value", v?.ToString()))
//            };
//    }
//}

//public static class UiGridExtensions
//{
//    public static IReadOnlyList<PropMeta> DesignPropsStatic()
//    {
//        object? Get(IDictionary<string, object?> bag, string key, object? fallback = null)
//            => bag.TryGetValue(key, out var v) ? v : fallback;

//        void Set(IDictionary<string, object?> bag, string key, object? value)
//            => bag[key] = value;

//        return new List<PropMeta>
//            {
//                new("Title","Label","string",
//                    c => Get(c.Params, "Title", "Grid"),
//                    (c,v)=> Set(c.Params, "Title", v?.ToString() ?? "Grid")),

//                new("Cols","Columns","int",
//                    c => Get(c.Params, "Cols", 3),
//                    (c,v)=> {
//                        var s = v?.ToString();
//                        var ok = int.TryParse(s, out var i);
//                        Set(c.Params, "Cols", ok ? Math.Max(1, i) : 3);
//                    }),

//                new("CssClass","CSS class","string",
//                    c => Get(c.Params, "CssClass", string.Empty),
//                    (c,v)=> Set(c.Params, "CssClass", v?.ToString() ?? string.Empty))
//                // Rows typically bound programmatically, so we omit here
//            };
//    }
//}

//public static class UiDatePickerExtensions
//{
//    public static IReadOnlyList<PropMeta> DesignPropsStatic()
//    {
//        object? Get(IDictionary<string, object?> bag, string key, object? fallback = null)
//            => bag.TryGetValue(key, out var v) ? v : fallback;

//        void Set(IDictionary<string, object?> bag, string key, object? value)
//            => bag[key] = value;

//        DateTime? ParseDate(object? v)
//        {
//            if (v is DateTime dt) return dt.Date;
//            if (v is string s && DateTime.TryParse(s, out var d)) return d.Date;
//            return null;
//        }

//        return new List<PropMeta>
//            {
//                new("Title","Label","string",
//                    c => Get(c.Params, "Title", "Date"),
//                    (c,v)=> Set(c.Params, "Title", v?.ToString() ?? "Date")),

//                new("Cols","Width (1-12)","int",
//                    c => Get(c.Params, "Cols", 1),
//                    (c,v)=> {
//                        var s = v?.ToString();
//                        var ok = int.TryParse(s, out var i);
//                        Set(c.Params, "Cols", ok ? Math.Clamp(i, 1, 12) : 1);
//                    }),

//                new("CssClass","CSS class","string",
//                    c => Get(c.Params, "CssClass", string.Empty),
//                    (c,v)=> Set(c.Params, "CssClass", v?.ToString() ?? string.Empty)),

//                new("Value","Value","date",
//                    c => Get(c.Params, "Value", null),
//                    (c,v)=> Set(c.Params, "Value", ParseDate(v))),

//                new("Min","Min","date",
//                    c => Get(c.Params, "Min", null),
//                    (c,v)=> Set(c.Params, "Min", ParseDate(v))),

//                new("Max","Max","date",
//                    c => Get(c.Params, "Max", null),
//                    (c,v)=> Set(c.Params, "Max", ParseDate(v)))
//            };
//    }
//}

