using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class SlicedPepperoni : IPepperoni
{
    public string Get()
    {
        return "Sliced Pepperoni";
    }
}