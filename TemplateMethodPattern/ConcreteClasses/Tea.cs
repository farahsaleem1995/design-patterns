using TemplateMethodPattern.AbstractClasses;

namespace TemplateMethodPattern.ConcreteClasses;

public class Tea : CaffeieneBeverage
{
    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }

    protected override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    protected override bool IsCondimentsWanted()
    {
        Console.WriteLine("Would you like lemon with your coffee? [y/N]");
        var input = Console.ReadLine() ?? "n";

        return input.ToLower().StartsWith("y");
    }
}