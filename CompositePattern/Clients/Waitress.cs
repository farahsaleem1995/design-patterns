using System.Globalization;
using CompositePattern.Components;

namespace CompositePattern.Clients;

public class Waitress
{
    private readonly MenuComponent _component;

    public Waitress(MenuComponent component)
    {
        _component = component;
    }

    public void PrintMenu()
    {
        _component.Print();
    }

    public void PrintVegetarianMenu()
    {
        var iterator = _component.CreateEnumerator();

        Console.WriteLine("\nVEGETARIAN MENU\n----");
        while (iterator.MoveNext())
        {
            var component = iterator.Current;
            try
            {
                if (component.Vegetarian)
                {
                    component.Print();
                }
            }
            catch (NotImplementedException) { }
        }
    }

    public void PrintMaxPriceMenu(double maxPrice)
    {
        var iterator = _component.CreateEnumerator();

        Console.WriteLine($"\nMAX PRICE({maxPrice.ToString("F", CultureInfo.InvariantCulture)}) MENU\n----");
        while (iterator.MoveNext())
        {
            var component = iterator.Current;
            try
            {
                if (component.Price < maxPrice)
                {
                    component.Print();
                }
            }
            catch (NotImplementedException) { }
        }
    }
}