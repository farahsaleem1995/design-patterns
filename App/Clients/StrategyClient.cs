using StrategyPattern.ConcreteStaregies;
using StrategyPattern.Context;

namespace App.Clients;

public class StrategyClient
{
    public static void Execute()
    {
        Duck mallard = new MallardDuck();
        mallard.PerformFly();
        mallard.PerforrmQuack();

        Console.WriteLine();

        Duck model = new ModelDuck();
        model.PerformFly();
        model.SetFlyBehavior(new FlyRocketPowered());
        model.PerformFly();
    }
}