using StrategyPattern.Strategies;

namespace StrategyPattern.Context;

public abstract class Duck
{
    protected IFlyBehavior? FlyBehavior;

    protected IQuackBehavior? QuackBehavior;

    public abstract void Display();

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        FlyBehavior = flyBehavior;
    }

    public void PerformFly()
    {
        FlyBehavior!.Fly();
    }

    public void PerforrmQuack()
    {
        QuackBehavior!.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}