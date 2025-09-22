using CiviTools.Models;
using CiviTools.Models.Extentions;
using Microsoft.AspNetCore.Components;

namespace CiviTools.Components.UI;

public partial class UiDatePickerBase : ComponentBase
{
    [Parameter] public UiDatePicker Model { get; set; } = new();


    protected string Title => Model.Title;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;


    protected DateTime? Value { get; set; }
    public static IReadOnlyList<PropMeta> DesignProps { get; } = UiDatePickerExtensions.DesignPropsStatic();
    public static IEnumerable<PropMeta> PropMetas => DesignProps;
}



