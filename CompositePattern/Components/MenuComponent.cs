namespace CompositePattern.Components;

public abstract class MenuComponent
{
    public virtual string Name => throw new NotImplementedException();
    public virtual string Description => throw new NotImplementedException();
    public virtual double Price => throw new NotImplementedException();
    public virtual bool Vegetarian => throw new NotImplementedException();

    public virtual void Add(MenuComponent component)
    {
        throw new NotImplementedException();
    }

    public virtual MenuComponent GetChild(int i)
    {
        throw new NotImplementedException();
    }

    public virtual IEnumerable<MenuComponent> GetChilds()
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(MenuComponent component)
    {
        throw new NotImplementedException();
    }

    public abstract IEnumerator<MenuComponent> CreateEnumerator();

    public abstract void Print();
}