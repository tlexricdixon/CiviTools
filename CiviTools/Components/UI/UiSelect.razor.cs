using CiviTools.Models;
using Microsoft.AspNetCore.Components;

namespace CiviTools.Components.UI;




public class UiSelectBase : ComponentBase
{
    [Parameter] public UiSelect Model { get; set; } = new();


    protected string Title => Model.Title;
    protected List<string> Items => Model.Items;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;


    protected string? Selected { get; set; }
}



