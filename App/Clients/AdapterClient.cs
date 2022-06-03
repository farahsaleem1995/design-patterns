using AdapterPattern;
using AdapterPattern.Adaptees;
using AdapterPattern.Adapters;
using AdapterPattern.Targets;

namespace App.Clients;

public class AdapterClient
{
    public static void Execute()
    {
        IDuck mallardDuck = new MallardDuck();

        ITurkey wildTurky = new WildTurky();
        IDuck wildTurkeyAdapter = new TurkeyAdapter(wildTurky);

        Console.WriteLine("The Turkey says...");
        wildTurky.Gobble();
        wildTurky.Fly();
        Console.WriteLine();

        Console.WriteLine("The Duck says...");
        mallardDuck.Quack();
        mallardDuck.Fly();
        Console.WriteLine();

        TestDuck(mallardDuck);
        Console.WriteLine();
        TestDuck(wildTurkeyAdapter);
        Console.WriteLine();
    }

    private static void TestDuck(IDuck duck)
    {
        duck.Quack();
        duck.Fly();
    }
}