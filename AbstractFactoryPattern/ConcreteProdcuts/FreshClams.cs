using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class FreshClams : IClams
{
    public string Get()
    {
        return "Fresh Clams from Long Island Sound";
    }
}