using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class ReggianoCheese : ICheese
{
    public string Get()
    {
        return "Reggiano Cheese";
    }
}