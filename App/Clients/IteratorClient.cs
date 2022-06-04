using IteratorPattern.Aggregates;
using IteratorPattern.Clients;
using IteratorPattern.ConcreteAggregates;

namespace App.Clients;

public class IteratorClient
{
    public static void Execute()
    {
        IMenu pancakeMenu = new PanckaeHouseMenu();
        IMenu dinerMenu = new DinerMenu();
        IMenu cafeMenu = new CafeMenu();

        var waitress = new Waitress(pancakeMenu, dinerMenu, cafeMenu);
        waitress.PrintMenu();
    }
}