using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public abstract class CondimentDecorator : Beverage
{
    public abstract override string GetDescription();
}