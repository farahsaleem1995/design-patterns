using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class MarinaraSauce : ISauce
{
    public string Get()
    {
        return "Marinara Sauce";
    }
}