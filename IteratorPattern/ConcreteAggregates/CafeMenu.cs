using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Aggregates;
using IteratorPattern.ConcreteIterators;
using IteratorPattern.Iterators;

namespace IteratorPattern.ConcreteAggregates;

public class CafeMenu : IMenu
{
    private readonly IDictionary<string, MenuItem> _munuItems = new Dictionary<string, MenuItem>();

    public CafeMenu()
    {
        AddItem(new MenuItem("Veggie Burger and Air Fries",
                             "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                             true,
                             3.99));
        AddItem(new MenuItem("Soup of the day",
                             "A cup of the soup of the day, with a side salad",
                             false,
                             3.69));
        AddItem(new MenuItem("Burrito",
                             "A large burrito, with whole pinto beans, salsa, guacamole",
                             true,
                             4.29));
    }

    public void AddItem(MenuItem menuItem)
    {
        _munuItems.Add(menuItem.Name, menuItem);
    }

    public IMenuIterator CreateIterator()
    {
        return new CafeMenuIterator(_munuItems);
    }
}