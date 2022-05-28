using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class RedPepper : IVeggies
{
    public string Get()
    {
        return "Red Pepper";
    }
}