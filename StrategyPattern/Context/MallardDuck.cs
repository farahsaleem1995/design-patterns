using StrategyPattern.ConcreteStaregies;

namespace StrategyPattern.Context;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a real mallard duck.");
    }
}