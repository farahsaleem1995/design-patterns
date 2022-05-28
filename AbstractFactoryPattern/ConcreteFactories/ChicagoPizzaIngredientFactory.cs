using AbstractFactoryPattern.AbstractFactories;
using AbstractFactoryPattern.ConcreteProdcuts;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteFactories;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public IClams CreateClam()
    {
        return new FrozenClams();
    }

    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoesSauce();
    }

    public IEnumerable<IVeggies> CreateVeggies()
    {
        return new List<IVeggies>
        {
            new BlackOlives(),
            new Spinach(),
            new Eggplant(),
        };
    }
}