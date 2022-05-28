using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class Garlic : IVeggies
{
    public string Get()
    {
        return "Garlic";
    }
}