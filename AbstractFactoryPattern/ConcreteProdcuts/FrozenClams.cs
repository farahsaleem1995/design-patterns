using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class FrozenClams : IClams
{
    public string Get()
    {
        return "Frozen Clams from Chesapeake Bay";
    }
}