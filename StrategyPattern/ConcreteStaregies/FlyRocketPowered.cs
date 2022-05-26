using StrategyPattern.Strategies;

namespace StrategyPattern.ConcreteStaregies;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with rocket!!");
    }
}