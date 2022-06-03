using AdapterPattern.Adaptees;
using AdapterPattern.Targets;

namespace AdapterPattern.Adapters;

public class TurkeyAdapter : IDuck
{
    private readonly ITurkey _turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        _turkey = turkey;
    }

    public void Fly()
    {
        for (int i = 0; i < 5; i++)
        {
            _turkey.Fly();
        }
    }

    public void Quack()
    {
        _turkey.Gobble();
    }
}