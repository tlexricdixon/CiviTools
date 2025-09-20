namespace CiviTools.Models;

public class UiGrid : UiComponentBase
{
    // Simple demo dataset to show the grid without wiring data connectors yet
    public IEnumerable<object> Rows { get; set; } = new List<object>
    {
    new { Id=1, Name="Alice", Email="alice@example.com" },
    new { Id=2, Name="Bob", Email="bob@example.com" },
    new { Id=3, Name="Charlie", Email="charlie@example.com" },
    };
}
