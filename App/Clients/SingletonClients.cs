using SingletonPattern.Singleton;

namespace App.Clients;

public class SingletonClients
{
    public static void Execute()
    {
        Parallel.Invoke(
            () => Run(),
            () => Run(),
            () => Run(),
            () => Run(),
            () => Run());
    }

    private static void Run()
    {
        var boiler = ChocolateBoiler.Instance;
        boiler.Fill();
        boiler.Boil();
        boiler.Drain();
    }
}