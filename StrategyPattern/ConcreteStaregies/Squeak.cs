using StrategyPattern.Strategies;

namespace StrategyPattern.ConcreteStaregies;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}