namespace CiviTools.Models;

public class ComponentNode
{
    public UiComponentBase Component { get; set; }
    public List<ComponentNode> Children { get; set; } = new();
    public ComponentNode(UiComponentBase component) => Component = component;
}
// Property metadata for design-time editing
public record PropMeta(
string Name,
string Label,
string Type, // "string", "int", "bool", "select"
Func<UiComponentBase, object?> Getter,
Action<UiComponentBase, object?> Setter,
IEnumerable<(string Value, string Label)>? Options = null
);
