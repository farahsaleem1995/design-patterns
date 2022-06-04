using CompositePattern.Clients;
using CompositePattern.Composites;

namespace App.Clients;

public class CompositeClient
{
    public static void Execute()
    {
        var mainMenu = new Menu("ALL MENUS", "All menus combined");
        var desertMenu = new DesertMenu();
        var dinerMenu = new DinerMenu();
        var pancakeMenu = new PancakeMenu();
        var cafeMenu = new CafeMenu();

        dinerMenu.Add(desertMenu);
        mainMenu.Add(dinerMenu);
        mainMenu.Add(pancakeMenu);
        mainMenu.Add(cafeMenu);

        var waitress = new Waitress(mainMenu);
        waitress.PrintMenu();
        waitress.PrintVegetarianMenu();
        waitress.PrintMaxPriceMenu(2);
    }
}