namespace FacadePattern;

public class CdPlayer
{
    private readonly string _description;
    private readonly Amplifier _amplifier;
    private int _currentTrack;
    private string? _movie;

    public CdPlayer(string description, Amplifier amplifier)
    {
        _description = description;
        _amplifier = amplifier;
    }

    public void On()
    {
        Console.WriteLine($"{_description} on");
    }

    public void Off()
    {
        Console.WriteLine($"{_description} off");
    }

    public void Eject()
    {
        _movie = null;
        Console.WriteLine($"{_description} eject");
    }

    public void Play(String title)
    {
        _movie = title;
        _currentTrack = 0;
        Console.WriteLine($"{_description} playing \"{title}\"");
    }

    public void Play(int track)
    {
        if (_movie == null)
        {
            Console.WriteLine($"{_description} can't play track {_currentTrack}, no cd inserted");
        }
        else
        {
            _currentTrack = track;
            Console.WriteLine($"{_description} playing track {_currentTrack}");
        }
    }

    public void Stop()
    {
        _currentTrack = 0;
        Console.WriteLine($"{_description} stopped");
    }

    public void Pause()
    {
        Console.WriteLine($"{_description} paused \"{_movie}\"");
    }

    public override string ToString()
    {
        return _description;
    }
}