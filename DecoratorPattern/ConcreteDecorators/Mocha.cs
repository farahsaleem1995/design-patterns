using DecoratorPattern.Components;
using DecoratorPattern.Decorators;

namespace DecoratorPattern.ConcreteDecorators;

public class Mocha : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.20;
    }

    public override string GetDescription()
    {
        return string.Format("{0}, Mocha", _beverage.GetDescription());
    }
}