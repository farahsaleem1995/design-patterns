using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteProducts;

public class NyStyleClamPizza : Pizza
{
    public NyStyleClamPizza()
    {
        Name = "NY Style Clam Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Toppings.Add("Grated Reggiano Cheese");
        Toppings.Add("Fresh Clams from Long Island Sound");
    }
}