using AbstractFactoryPattern.AbstractFactories;
using AbstractFactoryPattern.Clients.ConcreteProducts;
using AbstractFactoryPattern.Clients.Creators;
using AbstractFactoryPattern.Clients.Products;

namespace AbstractFactoryPattern.Clients.ConcreteCreators;

public class ChicagoPizzaStore : PizzaStore
{
    public ChicagoPizzaStore(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
    }

    protected override Pizza CreatePizza(PizzaType type)
    {
        return type switch
        {
            PizzaType.Cheese => new CheesePizza(IngredientFactory)
            {
                Name = "Chicago Style Cheese Pizza"
            },
            PizzaType.Clam => new ClamPizza(IngredientFactory)
            {
                Name = "Chicago Style Clam Pizza"
            },
            PizzaType.Pepperoni => new PepperoniPizza(IngredientFactory)
            {
                Name = "Chicago Style Pepperoni Pizza"
            },
            PizzaType.Veggies => new VeggiesPizza(IngredientFactory)
            {
                Name = "Chicago Style Veggie Pizza"
            },
            _ => throw new ArgumentOutOfRangeException(),
        };
    }
}