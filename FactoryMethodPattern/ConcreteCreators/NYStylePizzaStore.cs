using FactoryMethodPattern.ConcreteProducts;
using FactoryMethodPattern.Creators;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteCreators;

public class NYStylePizzaStore : PizzaStoreBase
{
    protected override Pizza CreatePizza(PizzaType type)
    {
        return type switch
        {
            PizzaType.Cheese => new NYStyleCheesePizza(),
            PizzaType.Clam => new NYStyleCheesePizza(),
            PizzaType.Pepperoni => new NYStyleCheesePizza(),
            PizzaType.Verggie => new NYStyleCheesePizza(),
            _ => throw new NotImplementedException()
        };
    }
}