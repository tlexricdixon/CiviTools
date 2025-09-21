using CiviTools.Models;
using CiviTools.Models.Extentions;
using Microsoft.AspNetCore.Components;
namespace CiviTools.Components.UI;

public class UiTextFieldBase : ComponentBase
{
    [Parameter] public Models.UiTextField? Model { get; set; }
    [Parameter] public string? Value { get; set; }
    [Parameter] public EventCallback<string?> ValueChanged { get; set; }

    public string Title => Model!.Title;
    protected string Placeholder => Model!.Placeholder;
    protected string Help => Model!.Help;
    protected int Cols => Model!.Cols;
    protected string CssClass => Model!.CssClass;

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

    // Optional: cached design props for the property panel
    public static IReadOnlyList<PropMeta> DesignProps { get; } = UiTextFieldExtensions.DesignPropsStatic();
    public static IEnumerable<PropMeta> PropMetas => DesignProps;
}


