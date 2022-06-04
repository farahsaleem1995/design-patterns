using CompositePattern.Leaves;

namespace CompositePattern.Composites;

public class DinerMenu : Menu
{
    public DinerMenu() : base("DINER MENU", "Lunch")
    {
        Add(new MenuItem("Vegetarian BLT",
                         "(Fakin') Bacon with lettuce & tomato on whole wheat",
                         true,
                         2.99));
        Add(new MenuItem("BLT",
                         "Bacon with lettuce & tomato on whole wheat",
                         false,
                         2.99));
        Add(new MenuItem("Soup of the day",
                         "Soup of the day, with a side of potato salad",
                         false,
                         3.29));
        Add(new MenuItem("Hot dog",
                         "A hot dog, with saurkraut, relish, onions, topped with cheese",
                         false,
                         3.05));
        Add(new MenuItem("Steamed Veggies and Brown Rice",
                         "Steamed vegetables over brown rice",
                         true,
                         3.99));
        Add(new MenuItem("Pasta",
                         "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                         true,
                         3.89));
    }
}