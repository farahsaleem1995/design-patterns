using IteratorPattern.Aggregates;
using IteratorPattern.ConcreteIterators;
using IteratorPattern.Iterators;

namespace IteratorPattern.ConcreteAggregates;

public class DinerMenu : IMenu
{
    private const int MenuLength = 10;
    private readonly MenuItem[] _menuItems = new MenuItem[MenuLength];
    private int _currentCount = 0;

    public DinerMenu()
    {
        _menuItems[0] = new MenuItem("Vegetarian BLT",
                                     "(Fakin') Bacon with lettuce & tomato on whole wheat",
                                     true,
                                     2.99);
        _menuItems[1] = new MenuItem("BLT",
                                     "Bacon with lettuce & tomato on whole wheat",
                                     false,
                                     2.99);
        _menuItems[2] = new MenuItem("Soup of the day",
                                     "Soup of the day, with a side of potato salad",
                                     false,
                                     3.29);
        _menuItems[3] = new MenuItem("Hot dog",
                                     "A hot dog, with saurkraut, relish, onions, topped with cheese",
                                     false,
                                     3.05);
        _menuItems[4] = new MenuItem("Steamed Veggies and Brown Rice",
                                     "Steamed vegetables over brown rice",
                                     true,
                                     3.99);
        _menuItems[5] = new MenuItem("Pasta",
                                     "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                                     true,
                                     3.89);
    }

    public void AddItem(MenuItem menuItem)
    {
        if (_currentCount >= MenuLength)
        {
            throw new InvalidOperationException(
                string.Format("Unable to add more than {0} menu items.", MenuLength));
        }

        _menuItems[_currentCount] = menuItem;
        _currentCount++;
    }

    public IMenuIterator CreateIterator()
    {
        return new DinerMenuIterator(_menuItems);
    }
}