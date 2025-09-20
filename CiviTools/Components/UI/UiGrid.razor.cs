using CiviTools.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using System.Reflection;
namespace CiviTools.Components.UI;




public class UiGridBase : UiComponentBase
{
    [Parameter] public UiGrid Model { get; set; } = new();


    protected string Title => Model.Title;
    protected int Cols => Model.Cols;
    protected string CssClass => Model.CssClass;
    protected IEnumerable<object> Rows => Model.Rows;
    protected IEnumerable<PropertyInfo> Columns => Rows.FirstOrDefault()?.GetType().GetProperties() ?? Array.Empty<PropertyInfo>();
}



