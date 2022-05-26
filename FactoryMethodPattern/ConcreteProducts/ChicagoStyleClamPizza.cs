using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteProducts;

public class ChicagoStyleClamPizza : Pizza
{
    public ChicagoStyleClamPizza()
    {
        Name = "Chicago Style Clam Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Toppings.Add("Shredded Mozzarella Cheese");
        Toppings.Add("Frozen Clams from Chesapeake Bay");
    }
}