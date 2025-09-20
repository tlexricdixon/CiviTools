using CiviTools.Models;
using CiviTools.Models.Extentions;
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
        Register(new Descriptor(
           "text",
           "Text Field",
           () => new UiTextField { Title = "Text", Placeholder = "Enter text" },
           () => UIExtentions.DesignProps(new())   // ← compile-time safe, no instance
       ));


        Register(
        new Descriptor(
        "select",
        "Select",
        () => new UiSelect { Title = "Select", Items = new() { "One", "Two", "Three" } },
        () => UiSelectExtensions.DesignProps(new())
        ));


        Register(
        new Descriptor(
        "date",
        "Date Picker",
        () => new UiDatePicker { Title = "Date" },
        () => UiDatePickerExtensions.DesignProps(new())
        ));


        Register(
        new Descriptor(
        "grid",
        "Grid",
        () => new UiGrid { Title = "Grid" },
        () => UiGridExtensions.DesignProps(new())
        ));
    }


    public void Register(Descriptor d) => _descriptors.Add(d);
    public IEnumerable<Descriptor> All() => _descriptors;
}
