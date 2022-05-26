using FactoryMethodPattern;
using FactoryMethodPattern.ConcreteCreators;
using FactoryMethodPattern.Creators;
using FactoryMethodPattern.Products;

namespace App.Clients;

public class FactoryMethodClient
{
    public static void Execute()
    {
        PizzaStoreBase nyPizzaStore = new NYStylePizzaStore();
        PizzaStoreBase chicagoPizzaStore = new ChicagoStylePizzaStore();

        Pizza nyPizza = nyPizzaStore.OrderPizza(PizzaType.Cheese);
        Console.WriteLine($"Ethan ordered a {nyPizza.GetName()} \n");

        Pizza chicagoPizza = chicagoPizzaStore.OrderPizza(PizzaType.Cheese);
        Console.WriteLine($"Joel ordered a {chicagoPizza.GetName()} \n");
    }
}