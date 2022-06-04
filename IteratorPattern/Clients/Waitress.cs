using IteratorPattern.Aggregates;
using IteratorPattern.Iterators;

namespace IteratorPattern.Clients;

public class Waitress
{
    private readonly IMenu _pancakeHouseMenu;
    private readonly IMenu _dinerMenu;
    private readonly IMenu _cafeMenu;

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
    {
        _pancakeHouseMenu = pancakeHouseMenu;
        _dinerMenu = dinerMenu;
        _cafeMenu = cafeMenu;
    }

    public void PrintMenu()
    {
        Console.WriteLine("MENU\n----");

        Console.WriteLine("\nBREAKFAST");
        PrintMenuItems(_pancakeHouseMenu.CreateIterator());

        Console.WriteLine("\nLAUNCH");
        PrintMenuItems(_dinerMenu.CreateIterator());

        Console.WriteLine("\nDINNER");
        PrintMenuItems(_cafeMenu.CreateIterator());
    }

    private void PrintMenuItems(IMenuIterator menuterator)
    {
        while (menuterator.HasNext())
        {
            Console.WriteLine(menuterator.Next());
        }
    }
}