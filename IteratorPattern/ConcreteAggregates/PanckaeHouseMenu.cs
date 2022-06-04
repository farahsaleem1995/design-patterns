using IteratorPattern.Aggregates;
using IteratorPattern.ConcreteIterators;
using IteratorPattern.Iterators;

namespace IteratorPattern.ConcreteAggregates;

public class PanckaeHouseMenu : IMenu
{
    private readonly List<MenuItem> _menuItems = new()
    {
        new MenuItem("K&B's Pancake Breakfast",
                     "Pancakes with scrambled eggs, and toast",
                     true,
                     2.99),
        new MenuItem("Regular Pancake Breakfast",
                     "Pancakes with fried eggs, sausage",
                     false,
                     2.99),
        new MenuItem("Blueberry Pancakes",
                     "Pancakes made with fresh blueberries, and blueberry syrup",
                     true,
                     3.49),
        new MenuItem("Waffles",
                     "Waffles, with your choice of blueberries or strawberries",
                     true,
                     3.59),
    };

    public void AddItem(MenuItem menuItem)
    {
        _menuItems.Add(menuItem);
    }

    public IMenuIterator CreateIterator()
    {
        return new PanckaeHouseMenuIterator(_menuItems);
    }
}