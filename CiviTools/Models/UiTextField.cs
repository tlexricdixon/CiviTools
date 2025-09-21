namespace CiviTools.Models;

public class UiTextField : UiComponentBase
{
    public string Placeholder { get; set; } = string.Empty;
    public string Help { get; set; } = string.Empty;
    public string? InitialValue { get; set; }
}
