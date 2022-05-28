using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class Eggplant : IVeggies
{
    public string Get()
    {
        return "Eggplant";
    }
}