using CompositePattern.Leaves;

namespace CompositePattern.Composites;

public class PancakeMenu : Menu
{
    public PancakeMenu() : base("PANCAKE HOUSE MENU", "Breakfast")
    {
        Add(new MenuItem("K&B's Pancake Breakfast",
                         "Pancakes with scrambled eggs, and toast",
                         true,
                         2.99));
        Add(new MenuItem("Regular Pancake Breakfast",
                         "Pancakes with fried eggs, sausage",
                         false,
                         2.99));
        Add(new MenuItem("Blueberry Pancakes",
                         "Pancakes made with fresh blueberries, and blueberry syrup",
                         true,
                         3.49));
        Add(new MenuItem("Waffles",
                         "Waffles, with your choice of blueberries or strawberries",
                         true,
                         3.59));
    }
}