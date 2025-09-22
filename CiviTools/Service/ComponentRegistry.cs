using CiviTools.Components.UI;
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
            () => new Models.UiTextField { Title = "Text", Placeholder = "Enter text" },
            () => UiTextFieldBase.DesignProps
        ));


        Register(
        new Descriptor(
        "select",
        "Select",
        () => new Models.UiSelect { Title = "Select", Items = new() { "One", "Two", "Three" } },
        () => UiSelectExtensions.DesignPropsStatic()
        ));


        Register(
        new Descriptor(
        "date",
        "Date Picker",
        () => new Models.UiDatePicker { Title = "Date" },
        () => UiDatePickerExtensions.DesignPropsStatic()
        ));


        Register(
        new Descriptor(
        "grid",
        "Grid",
        () => new Models.UiGrid { Title = "Grid" },
        () => UiGridExtensions.DesignPropsStatic()
        ));
    }


    public void Register(Descriptor d) => _descriptors.Add(d);
    public IEnumerable<Descriptor> All() => _descriptors;
}
