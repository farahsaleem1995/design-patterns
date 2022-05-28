using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class ThickCrustDough : IDough
{
    public string Get()
    {
        return "ThickCrust style extra thick crust dough";
    }
}