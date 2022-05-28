using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class Mushroom : IVeggies
{
    public string Get()
    {
        return "Mushrooms";
    }
}