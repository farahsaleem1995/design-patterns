using AbstractFactoryPattern.AbstractFactories;
using AbstractFactoryPattern.Clients.ConcreteProducts;
using AbstractFactoryPattern.Clients.Creators;
using AbstractFactoryPattern.Clients.Products;

namespace AbstractFactoryPattern.Clients.ConcreteCreators;

public class NYPizzaStore : PizzaStore
{
    public NYPizzaStore(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
    }

    protected override Pizza CreatePizza(PizzaType type)
    {
        return type switch
        {
            PizzaType.Cheese => new CheesePizza(IngredientFactory)
            {
                Name = "New York Style Cheese Pizza"
            },
            PizzaType.Clam => new ClamPizza(IngredientFactory)
            {
                Name = "New York Style Clam Pizza"
            },
            PizzaType.Pepperoni => new PepperoniPizza(IngredientFactory)
            {
                Name = "New York Style Pepperoni Pizza"
            },
            PizzaType.Veggies => new VeggiesPizza(IngredientFactory)
            {
                Name = "New York Style Veggie Pizza"
            },
            _ => throw new ArgumentOutOfRangeException(),
        };
    }
}