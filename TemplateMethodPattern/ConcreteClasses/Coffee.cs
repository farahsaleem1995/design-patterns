using TemplateMethodPattern.AbstractClasses;

namespace TemplateMethodPattern.ConcreteClasses;

public class Coffee : CaffeieneBeverage
{
    protected override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }

    protected override void Brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    protected override bool IsCondimentsWanted()
    {
        Console.WriteLine("Would you like milk and sugar with your coffee? [y/N]");
        var input = Console.ReadLine() ?? "n";

        return input.ToLower().StartsWith("y");
    }
}