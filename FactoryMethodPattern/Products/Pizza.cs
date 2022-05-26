namespace FactoryMethodPattern.Products;

public abstract class Pizza
{
    protected string Name = string.Empty;
    protected string Dough = string.Empty;
    protected string Sauce = string.Empty;
    protected IList<string> Toppings = new List<string>();

    public void Prepaer()
    {
        Console.WriteLine($"Preparing {Name}...");
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings:");
        foreach (var item in Toppings)
        {
            Console.WriteLine($"\t{item}");
        }
    }

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in an official PizzaStore box");
    }

    public string GetName()
    {
        return Name;
    }
}