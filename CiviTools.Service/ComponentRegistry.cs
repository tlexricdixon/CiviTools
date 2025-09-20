using CiviTools.Components.UI;
using CiviTools.Models;
namespace CiviTools.Service;

public class ComponentRegistry
{
    public record Descriptor(
string TypeKey,
string DisplayName,
Func<UiComponentBase> Factory,
Func<IEnumerable<PropMeta>> DesignProps
);


    private readonly List<Descriptor> _descriptors = new();


    public ComponentRegistry()
    {
        // Register built-ins
        Register(
        new Descriptor(
        "text",
        "Text Field",
        () => new UiTextField { Title = "Text", Placeholder = "Enter text" },
        () => UiTextField.DesignProps()
        ));


        Register(
        new Descriptor(
        "select",
        "Select",
        () => new UiSelect { Title = "Select", Items = new() { "One", "Two", "Three" } },
        () => UiSelect.DesignProps()
        ));


        Register(
        new Descriptor(
        "date",
        "Date Picker",
        () => new UiDatePicker { Title = "Date" },
        () => UiDatePicker.DesignProps()
        ));


        Register(
        new Descriptor(
        "grid",
        "Grid",
        () => new UiGrid { Title = "Grid" },
        () => UiGrid.DesignProps()
        ));
    }


    public void Register(Descriptor d) => _descriptors.Add(d);
    public IEnumerable<Descriptor> All() => _descriptors;
}
