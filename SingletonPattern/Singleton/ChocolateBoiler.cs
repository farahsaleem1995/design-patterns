namespace SingletonPattern.Singleton;

public class ChocolateBoiler
{
    private static ChocolateBoiler? _instance;
    private static readonly object _instanceLock = new();

    private ChocolateBoiler()
    {
        Id = new Random().Next(1, 1000);
    }

    public int Id { get; private init; }

    public bool Empty { get; private set; }

    public bool Boiled { get; private set; }

    public static ChocolateBoiler Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new ChocolateBoiler();
                    }
                }
            }

            return _instance;
        }
    }

    public void Boil()
    {
        Console.WriteLine("Boiling");
        Console.WriteLine($"Boiler ID: {Id}");

        if (!Empty && !Boiled)
        {
            Boiled = true;
        }
    }

    public void Drain()
    {
        Console.WriteLine("Draining");
        Console.WriteLine($"Boiler ID: {Id}");

        if (!Empty && Boiled)
        {
            Empty = true;
            Boiled = false;
        }
    }

    public void Fill()
    {
        Console.WriteLine("Filling");
        Console.WriteLine($"Boiler ID: {Id}");

        if (Empty)
        {
            Empty = false;
        }
    }
}