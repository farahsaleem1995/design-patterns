namespace CommandPattern.Receivers;

public class Light
{
    private string _location = "";

    public Light(String location)
    {
        _location = location;
    }

    public void On()
    {
        Console.WriteLine(_location + " light is on");
    }

    public void Off()
    {
        Console.WriteLine(_location + " light is off");
    }
}