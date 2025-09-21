using CiviTools.Models;
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
}



