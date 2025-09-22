using CiviTools.Models;
using CiviTools.Models.Extentions;
using Microsoft.AspNetCore.Components;
using System.Reflection;
namespace CiviTools.Components.UI;




public class UiGridBase : ComponentBase
{
    [Parameter] public UiGrid Model { get; set; } = new();


    public string Title => Model.Title;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;
    protected IQueryable<object> Rows => Model.Rows;
    protected IEnumerable<PropertyInfo> Columns => Rows.FirstOrDefault()?.GetType().GetProperties() ?? Array.Empty<PropertyInfo>();
    protected override void OnParametersSet()
    {
        if (Model != null)
        {
            if (Model.Title == null)
                Model.Title = "Text";
            Value ??= Model.InitialValue;
        }
    }

    protected async Task SetValueAsync(ChangeEventArgs e)
    {
        Value = e?.Value?.ToString();
        if (ValueChanged.HasDelegate)
            await ValueChanged.InvokeAsync(Value);
    }
    public static IReadOnlyList<PropMeta> DesignProps { get; } = UiGridExtensions.DesignPropsStatic();
    public static IEnumerable<PropMeta> PropMetas => DesignProps;
}



