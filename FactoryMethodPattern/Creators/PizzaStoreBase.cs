using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Creators;

public abstract class PizzaStoreBase
{
    public Pizza OrderPizza(PizzaType type)
    {
        var pizza = CreatePizza(type);

        pizza.Prepaer();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    protected abstract Pizza CreatePizza(PizzaType type);
}