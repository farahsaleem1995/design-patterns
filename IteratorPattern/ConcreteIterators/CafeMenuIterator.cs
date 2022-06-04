using IteratorPattern.Iterators;

namespace IteratorPattern.ConcreteIterators;

public class CafeMenuIterator : IMenuIterator
{
    private readonly IDictionary<string, MenuItem> _menuItems;
    private int _position = 0;

    public CafeMenuIterator(IDictionary<string, MenuItem> menuItems)
    {
        _menuItems = menuItems;
    }

    public bool HasNext()
    {
        return _position < _menuItems.Count;
    }

    public MenuItem Next()
    {
        var item = _menuItems.ElementAt(_position);
        _position++;
        return item.Value;
    }
}