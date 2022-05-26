using DecoratorPattern.Components;
using DecoratorPattern.Decorators;

namespace DecoratorPattern.ConcreteDecorators;

public class Whip : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }

    public override string GetDescription()
    {
        return string.Format("{0}, Whip", _beverage.GetDescription());
    }
}