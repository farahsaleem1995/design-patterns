using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class BlackOlives : IVeggies
{
    public string Get()
    {
        return "Black Olives";
    }
}