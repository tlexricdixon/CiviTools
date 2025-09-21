using CiviTools.Models;
using static CiviTools.Service.ComponentRegistry;

namespace CiviTools.Components.Pages
{
    public partial class Designer
    {
        private List<ComponentNode> Canvas { get; set; } = new();
        private ComponentNode? _selected;
        private IReadOnlyList<PropMeta> _designProps = [];
        private int? _dragIndex;
        private int? _dropIndex;
        public void AddComponent(Descriptor d)
        {
            var comp = d.Factory();          // UiComponentBase
            var node = new ComponentNode(comp);
            Canvas.Add(node);
            Select(node);
            StateHasChanged();
        }

        public void Select(ComponentNode node)
        {
            _selected = node;

            // Find the descriptor for this component type to pull its design props
            var desc = Registry.All().FirstOrDefault(r => r.Factory().GetType() == node.Component.GetType());
            _designProps = desc is not null
                ? desc.DesignProps().ToList()
                : Array.Empty<PropMeta>();
        }

        public void SetProp(PropMeta pm, object? val)
        {
            if (_selected is null) return;
            pm.Setter(_selected.Component, val);
            StateHasChanged();
        }

        public void MoveUp()
        {
            if (_selected is null) return;
            var i = Canvas.FindIndex(n => n.Component.Id == _selected.Component.Id);
            if (i > 0)
            {
                (Canvas[i - 1], Canvas[i]) = (Canvas[i], Canvas[i - 1]);
                StateHasChanged(); // Add this
            }
        }

        public void MoveDown()
        {
            if (_selected is null) return;
            var i = Canvas.FindIndex(n => n.Component.Id == _selected.Component.Id);
            if (i >= 0 && i < Canvas.Count - 1)
            {
                (Canvas[i + 1], Canvas[i]) = (Canvas[i], Canvas[i + 1]);
                StateHasChanged(); // Add this
            }
        }

        public void RemoveSelected()
        {
            if (_selected is null) return;
            Canvas.RemoveAll(n => n.Component.Id == _selected.Component.Id);
            _selected = null;
            _designProps = Array.Empty<PropMeta>();
            StateHasChanged(); // Add this
        }
        public void OnDragStart(int index)
        {
            _dragIndex = index;
            _dropIndex = null;
        }

        public void OnDragOver(int index)
        {
            _dropIndex = index;
            StateHasChanged(); // refresh to show visual hint
        }

        public void OnDrop(int index)
        {
            if (_dragIndex is null) return;

            var from = _dragIndex.Value;
            var to = index;

            if (from == to) { _dragIndex = _dropIndex = null; return; }

            var item = Canvas[from];
            Canvas.RemoveAt(from);
            if (to > from) to--; // adjust when dragging downward
            Canvas.Insert(to, item);

            _dragIndex = _dropIndex = null;
            StateHasChanged(); // Add this
        }
    }
}
