using CompositePattern.Leaves;

namespace CompositePattern.Composites;

public class CafeMenu : Menu
{
    public CafeMenu() : base("CAFE MENU", "Dinner")
    {
        Add(new MenuItem("Veggie Burger and Air Fries",
                         "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                         true,
                         3.99));
        Add(new MenuItem("Soup of the day",
                         "A cup of the soup of the day, with a side salad",
                         false,
                         3.69));
        Add(new MenuItem("Burrito",
                         "A large burrito, with whole pinto beans, salsa, guacamole",
                         true,
                         4.29));
    }
}