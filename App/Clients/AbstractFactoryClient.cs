using AbstractFactoryPattern;
using AbstractFactoryPattern.Clients;
using AbstractFactoryPattern.Clients.ConcreteCreators;
using AbstractFactoryPattern.Clients.Products;
using AbstractFactoryPattern.ConcreteFactories;

namespace App.Clients;

public class AbstractFactoryClient
{
    public static void Execute()
    {
        var nyFactory = new NYPizzaIngredientFactory();
        var chicagoFactory = new ChicagoPizzaIngredientFactory();

        var nyStore = new NYPizzaStore(nyFactory);
        var chicagoStore = new ChicagoPizzaStore(chicagoFactory);

        Pizza pizza = nyStore.OrderPizza(PizzaType.Cheese);
        Console.WriteLine($"* Ethan ordered a {pizza.Name}");
        Console.WriteLine(pizza);

        pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
        Console.WriteLine($"* Joel ordered a {pizza.Name}");
        Console.WriteLine(pizza);

        pizza = nyStore.OrderPizza(PizzaType.Clam);
        Console.WriteLine($"* Ethan ordered a {pizza.Name}");
        Console.WriteLine(pizza);

        pizza = chicagoStore.OrderPizza(PizzaType.Clam);
        Console.WriteLine($"* Joel ordered a {pizza.Name}");
        Console.WriteLine(pizza);

        pizza = nyStore.OrderPizza(PizzaType.Pepperoni);
        Console.WriteLine($"* Ethan ordered a {pizza.Name}");
        Console.WriteLine(pizza);

        pizza = chicagoStore.OrderPizza(PizzaType.Pepperoni);
        Console.WriteLine($"* Joel ordered a {pizza.Name}");
        Console.WriteLine(pizza);

        pizza = nyStore.OrderPizza(PizzaType.Veggies);
        Console.WriteLine($"* Ethan ordered a {pizza.Name}");
        Console.WriteLine(pizza);

        pizza = chicagoStore.OrderPizza(PizzaType.Veggies);
        Console.WriteLine($"* Joel ordered a {pizza.Name}");
        Console.WriteLine(pizza);
    }
}