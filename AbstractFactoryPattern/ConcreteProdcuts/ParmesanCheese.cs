using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class ParmesanCheese : ICheese
{
    public string Get()
    {
        return "Parmesan Cheese";
    }
}