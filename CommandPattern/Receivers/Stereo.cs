namespace CommandPattern.Receivers;

public class Stereo
{
    private readonly string _location;

    public Stereo(string location)
    {
        _location = location;
    }

    public StereoState State { get; private set; }
    public StereoType Type { get; private set; }

    public int Volume { get; private set; }

    public void On()
    {
        State = StereoState.On;
        Console.WriteLine(_location + " stereo is on");
    }

    public void Off()
    {
        State = StereoState.Off;
        Console.WriteLine(_location + " stereo is off");
    }

    public void SetCD()
    {
        Type = StereoType.CD;
        Console.WriteLine(_location + " stereo is set for CD input");
    }

    public void SetDVD()
    {
        Type = StereoType.DVD;
        Console.WriteLine(_location + " stereo is set for DVD input");
    }

    public void SetRadio()
    {
        Type = StereoType.Radio;
        Console.WriteLine(_location + " stereo is set for Radio");
    }

    public void SetVolume(int volume)
    {
        // code to set the volume
        // valid range: 1-11 (after all 11 is better than 10, right?)
        Volume = volume;
        Console.WriteLine(_location + " stereo volume set to " + volume);
    }
}

public enum StereoState
{
    Off,
    On
}

public enum StereoType
{
    CD,
    DVD,
    Radio
}