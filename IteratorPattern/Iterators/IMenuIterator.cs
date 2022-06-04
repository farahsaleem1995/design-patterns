namespace IteratorPattern.Iterators;

public interface IMenuIterator
{
    bool HasNext();

    MenuItem Next();
}