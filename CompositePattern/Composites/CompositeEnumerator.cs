using System.Collections;
using CompositePattern.Components;

namespace CompositePattern.Composites;

public class CompositeEnumerator : IEnumerator<MenuComponent>
{
    private Stack<IEnumerator<MenuComponent>>? _stack = new();

    public CompositeEnumerator(IEnumerator<MenuComponent> enumerator)
    {
        _stack.Push(enumerator);
    }

    public MenuComponent Current
    {
        get
        {
            if (_stack == null)
            {
                throw new ObjectDisposedException("Unable to enumerate through disposed object.");
            }

            var iterator = _stack.Peek();
            var component = iterator.Current;
            _stack.Push(component.CreateEnumerator());
            return component;
        }
    }

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        _stack = null;
    }

    public bool MoveNext()
    {
        if (_stack == null)
        {
            throw new ObjectDisposedException("Unable to enumerate through disposed object.");
        }

        if (_stack.Count == 0)
        {
            return false;
        }

        var iterator = _stack.Peek();
        if (!iterator.MoveNext())
        {
            _stack.Pop();
            return MoveNext();
        }

        return true;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}