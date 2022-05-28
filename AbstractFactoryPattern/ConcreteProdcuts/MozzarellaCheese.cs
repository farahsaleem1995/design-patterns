using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class MozzarellaCheese : ICheese
{
    public string Get()
    {
        return "Shredded Mozzarella";
    }
}