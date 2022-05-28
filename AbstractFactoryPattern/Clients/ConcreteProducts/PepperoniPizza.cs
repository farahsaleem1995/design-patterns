using AbstractFactoryPattern.AbstractFactories;
using AbstractFactoryPattern.Clients.Products;

namespace AbstractFactoryPattern.Clients.ConcreteProducts;

public class PepperoniPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");

        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Veggies = _ingredientFactory.CreateVeggies();
        Pepperoni = _ingredientFactory.CreatePepperoni();
    }
}