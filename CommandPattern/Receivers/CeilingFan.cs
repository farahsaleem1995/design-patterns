namespace CommandPattern.Receivers;

public class CeilingFan
{
    private readonly string _location = "";
    private int _level;
    public const int High = 3;
    public const int Medium = 2;
    public const int Low = 1;

    public CeilingFan(string location)
    {
        _location = location;
    }

    public int Speed => _level;

    public void OnHigh()
    {
        // turns the ceiling fan on to high
        _level = High;
        Console.WriteLine(_location + " ceiling fan is on high");
    }

    public void OnMedium()
    {
        // turns the ceiling fan on to medium
        _level = Medium;
        Console.WriteLine(_location + " ceiling fan is on medium");
    }

    public void OnLow()
    {
        // turns the ceiling fan on to low
        _level = Low;
        Console.WriteLine(_location + " ceiling fan is on low");
    }

    public void Off()
    {
        // turns the ceiling fan off
        _level = 0;
        Console.WriteLine(_location + " ceiling fan is off");
    }
}