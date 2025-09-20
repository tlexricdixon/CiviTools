using CiviTools.Models;
using Microsoft.AspNetCore.Components;

namespace CiviTools.Components.UI;

public partial class UiDatePickerBase : ComponentBase
{
    [Parameter] public UiDatePicker Model { get; set; } = new();


    protected string Title => Model.Title;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;


    protected DateTime? Value { get; set; }
}



