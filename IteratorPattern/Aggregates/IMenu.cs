using IteratorPattern.Iterators;

namespace IteratorPattern.Aggregates;

public interface IMenu
{
    IMenuIterator CreateIterator();
}