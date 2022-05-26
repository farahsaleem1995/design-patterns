using FactoryMethodPattern.ConcreteProducts;
using FactoryMethodPattern.Creators;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteCreators;

public class ChicagoStylePizzaStore : PizzaStoreBase
{
    protected override Pizza CreatePizza(PizzaType type)
    {
        return type switch
        {
            PizzaType.Cheese => new ChicagoStyleCheesePizza(),
            PizzaType.Clam => new ChicagoStyleCheesePizza(),
            PizzaType.Pepperoni => new ChicagoStyleCheesePizza(),
            PizzaType.Verggie => new ChicagoStyleCheesePizza(),
            _ => throw new NotImplementedException()
        };
    }
}