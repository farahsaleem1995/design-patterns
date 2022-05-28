using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class Onion : IVeggies
{
    public string Get()
    {
        return "Onion";
    }
}