using CompositePattern.Leaves;

namespace CompositePattern.Composites;

public class DesertMenu : Menu
{
    public DesertMenu() : base("DESSERT MENU", "Dessert of course!")
    {
        Add(new MenuItem("Apple Pie",
                         "Apple pie with a flakey crust, topped with vanilla icecream",
                         true,
                         1.59));

        Add(new MenuItem("Cheesecake",
                         "Creamy New York cheesecake, with a chocolate graham crust",
                         true,
                         1.99));
        Add(new MenuItem("Sorbet",
                         "A scoop of raspberry and a scoop of lime",
                         true,
                         1.89));
    }
}