using StrategyPattern.Strategies;

namespace StrategyPattern.ConcreteStaregies;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}