using CiviTools.Models;
using Microsoft.AspNetCore.Components;
namespace CiviTools.Components.UI;

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
