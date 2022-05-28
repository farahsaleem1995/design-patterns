using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteProdcuts;

public class PlumTomatoesSauce : ISauce
{
    public string Get()
    {
        return "Tomato sauce with plum tomatoes";
    }
}