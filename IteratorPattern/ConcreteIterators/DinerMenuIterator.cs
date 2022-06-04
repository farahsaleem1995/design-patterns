using IteratorPattern.Iterators;

namespace IteratorPattern.ConcreteIterators;

public class DinerMenuIterator : IMenuIterator
{
    private readonly MenuItem[] _menuItems;
    private int _position = 0;

    public DinerMenuIterator(MenuItem[] menuItems)
    {
        _menuItems = menuItems;
    }

    public bool HasNext()
    {
        return _position < _menuItems.Length && _menuItems[_position] != null;
    }

    public MenuItem Next()
    {
        var item = _menuItems[_position];
        _position++;
        return item;
    }
}