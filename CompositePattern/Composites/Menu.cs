using CompositePattern.Components;

namespace CompositePattern.Composites;

public class Menu : MenuComponent
{
    private readonly List<MenuComponent> _components = new();

    public Menu(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public override string Name { get; }
    public override string Description { get; }

    public override void Add(MenuComponent component)
    {
        _components.Add(component);
    }

    public override MenuComponent GetChild(int i)
    {
        return _components.ElementAt(i);
    }

    public override IEnumerable<MenuComponent> GetChilds()
    {
        return _components;
    }

    public override void Remove(MenuComponent component)
    {
        _components.Remove(component);
    }

    public override IEnumerator<MenuComponent> CreateEnumerator()
    {
        return new CompositeEnumerator(_components.GetEnumerator());
    }

    public override void Print()
    {
        Console.Write($"\n{Name}");
        Console.WriteLine($", {Description}");
        Console.WriteLine("--------------------");

        var enumerator = _components.GetEnumerator();
        while (enumerator.MoveNext())
        {
            enumerator.Current.Print();
        }
    }
}