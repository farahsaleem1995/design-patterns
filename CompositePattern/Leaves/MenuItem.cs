using CompositePattern.Components;

namespace CompositePattern.Leaves;

public class MenuItem : MenuComponent
{
    public MenuItem(string name,
                    string description,
                    bool vegeterian,
                    double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegeterian;
        Price = price;
    }

    public override string Name { get; }
    public override string Description { get; }
    public override double Price { get; }
    public override bool Vegetarian { get; }

    public override IEnumerator<MenuComponent> CreateEnumerator()
    {
        return new NullEnumerator();
    }

    public override void Print()
    {
        Console.Write($" {Name}");
        if (Vegetarian)
        {
            Console.Write("(v)");
        }
        Console.Write($", {Price}");
        Console.WriteLine($"     --- {Price}");
    }
}