namespace CommandPattern.Receivers;

public class Hottub
{
    private bool _on;

    public int Temperature { get; set; }

    public void On()
    {
        _on = true;
    }

    public void Off()
    {
        _on = false;
    }

    public void BubblesOn()
    {
        if (_on)
        {
            Console.WriteLine("Hottub is bubbling!");
        }
    }

    public void BubblesOff()
    {
        if (_on)
        {
            Console.WriteLine("Hottub is not bubbling");
        }
    }

    public void JetsOn()
    {
        if (_on)
        {
            Console.WriteLine("Hottub jets are on");
        }
    }

    public void JetsOff()
    {
        if (_on)
        {
            Console.WriteLine("Hottub jets are off");
        }
    }

    public void Heat()
    {
        Temperature = 105;
        Console.WriteLine("Hottub is heating to a steaming 105 degrees");
    }

    public void Cool()
    {
        Temperature = 98;
        Console.WriteLine("Hottub is cooling to 98 degrees");
    }
}