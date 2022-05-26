using DecoratorPattern.Components;
using DecoratorPattern.Decorators;

namespace DecoratorPattern.ConcreteDecorators;

public class SteamedMilk : CondimentDecorator
{
    private readonly Beverage _beverage;

    public SteamedMilk(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }

    public override string GetDescription()
    {
        return string.Format("{0}, Steamed Milk", _beverage.GetDescription());
    }
}