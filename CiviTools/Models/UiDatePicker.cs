namespace CiviTools.Models;

public class UiDatePicker : UiComponentBase 
{
    public string Placeholder { get; set; } = string.Empty;
    public string Help { get; set; } = string.Empty;
    // Optional: initial value carried by the model (designer can set)
    public string? InitialValue { get; set; }
}
