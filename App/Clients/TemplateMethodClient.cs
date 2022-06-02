using TemplateMethodPattern.AbstractClasses;
using TemplateMethodPattern.ConcreteClasses;

namespace App.Clients;

public class TemplateMethodClient
{
    public static void Execute()
    {
        CaffeieneBeverage coffee = new Coffee();
        coffee.PrepareRecipe();
        Console.WriteLine();

        CaffeieneBeverage tea = new Tea();
        tea.PrepareRecipe();
    }
}