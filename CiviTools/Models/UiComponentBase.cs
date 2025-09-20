namespace CiviTools.Models;

public abstract class UiComponentBase
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Key => Id.ToString("N");
    public string Title { get; set; } = string.Empty; // label/title in UI

    // Common layout props
    public int Cols { get; set; } = 12; // 1..12 grid columns
    public string CssClass { get; set; } = string.Empty;
}
