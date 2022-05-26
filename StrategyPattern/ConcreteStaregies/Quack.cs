using StrategyPattern.Strategies;

namespace StrategyPattern.ConcreteStaregies;

public class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Console.WriteLine("Quack");
    }
}