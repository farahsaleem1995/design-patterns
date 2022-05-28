using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class ThinCrustDough : IDough
{
    public string Get()
    {
        return "Thin Crust Dough";
    }
}