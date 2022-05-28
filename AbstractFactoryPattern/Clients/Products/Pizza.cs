using System.Text;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Clients.Products;

public abstract class Pizza
{
    protected IDough? Dough;
    protected ISauce? Sauce;
    protected IEnumerable<IVeggies> Veggies = new List<IVeggies>();
    protected ICheese? Cheese;
    protected IPepperoni? Pepperoni;
    protected IClams? Clam;

    public string Name { get; set; } = string.Empty;

    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.Append($"---- {Name} ----\n");
        if (Dough != null)
        {
            result.Append(Dough.Get());
            result.Append('\n');
        }
        if (Sauce != null)
        {
            result.Append(Sauce.Get());
            result.Append('\n');
        }
        if (Cheese != null)
        {
            result.Append(Cheese.Get());
            result.Append('\n');
        }
        if (Veggies.Any())
        {
            for (int i = 0; i < Veggies.Count(); i++)
            {
                result.Append(Veggies.ElementAt(i).Get());
                if (i < Veggies.Count() - 1)
                {
                    result.Append(", ");
                }
            }
            result.Append('\n');
        }
        if (Clam != null)
        {
            result.Append(Clam.Get());
            result.Append('\n');
        }
        if (Pepperoni != null)
        {
            result.Append(Pepperoni.Get());
            result.Append('\n');
        }
        return result.ToString();
    }
}