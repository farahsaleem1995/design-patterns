using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class Spinach : IVeggies
{
    public string Get()
    {
        return "Spinach";
    }
}