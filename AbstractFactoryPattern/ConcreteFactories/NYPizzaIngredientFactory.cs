using AbstractFactoryPattern.AbstractFactories;
using AbstractFactoryPattern.ConcreteProdcuts;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.ConcreteFactories;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public IClams CreateClam()
    {
        return new FreshClams();
    }

    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public IEnumerable<IVeggies> CreateVeggies()
    {
        return new List<IVeggies>
        {
            new Garlic(),
            new Onion(),
            new Mushroom(),
            new RedPepper()
        };
    }
}