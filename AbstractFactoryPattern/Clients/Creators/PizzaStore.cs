using AbstractFactoryPattern.AbstractFactories;
using AbstractFactoryPattern.Clients.Products;

namespace AbstractFactoryPattern.Clients.Creators;

public abstract class PizzaStore
{
    protected readonly IPizzaIngredientFactory IngredientFactory;

    public PizzaStore(IPizzaIngredientFactory ingredientFactory)
    {
        IngredientFactory = ingredientFactory;
    }

    public Pizza OrderPizza(PizzaType type)
    {
        var pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    protected abstract Pizza CreatePizza(PizzaType type);
}