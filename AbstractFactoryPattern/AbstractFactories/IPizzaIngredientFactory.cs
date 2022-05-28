using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.AbstractFactories;

public interface IPizzaIngredientFactory
{
    ICheese CreateCheese();

    IClams CreateClam();

    IDough CreateDough();

    IPepperoni CreatePepperoni();

    ISauce CreateSauce();

    IEnumerable<IVeggies> CreateVeggies();
}