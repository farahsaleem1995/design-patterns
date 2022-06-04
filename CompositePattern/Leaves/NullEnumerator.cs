using System.Collections;
using CompositePattern.Components;

namespace CompositePattern.Leaves;

public class NullEnumerator : IEnumerator<MenuComponent>
{
    public MenuComponent Current => throw new NullReferenceException();

    object IEnumerator.Current => throw new NullReferenceException();

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public bool MoveNext()
    {
        return false;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}