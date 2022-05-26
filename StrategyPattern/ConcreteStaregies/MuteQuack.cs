using StrategyPattern.Strategies;

namespace StrategyPattern.ConcreteStaregies;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}