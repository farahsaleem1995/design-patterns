using DecoratorPattern.Components;

namespace DecoratorPattern.ConcreteComponents;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast Coffee";
    }

    public override double Cost()
    {
        return 0.99;
    }
}