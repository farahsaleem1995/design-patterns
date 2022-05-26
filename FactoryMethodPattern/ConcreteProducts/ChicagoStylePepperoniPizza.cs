using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteProducts;

public class ChicagoStylePepperoniPizza : Pizza
{
    public ChicagoStylePepperoniPizza()
    {
        Name = "Chicago Style Pepperoni Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Toppings.Add("Shredded Mozzarella Cheese");
        Toppings.Add("Black Olives");
        Toppings.Add("Spinach");
        Toppings.Add("Eggplant");
        Toppings.Add("Sliced Pepperoni");
    }
}