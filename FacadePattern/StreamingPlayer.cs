namespace FacadePattern;

public class StreamingPlayer
{
    private readonly string _description;
    private readonly Amplifier _amplifier;
    private int _currentChapter;
    private string? _movie;

    public StreamingPlayer(string description, Amplifier amplifier)
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

    public void Play(String movie)
    {
        _movie = movie;
        _currentChapter = 0;
        Console.WriteLine($"{_description} playing \"{movie}\"");
    }

    public void Play(int chapter)
    {
        if (_movie == null)
        {
            Console.WriteLine($"{_description} can't play chapter {chapter} no movie selected");
        }
        else
        {
            _currentChapter = chapter;
            Console.WriteLine($"{_description} playing chapter {_currentChapter} of \"{_movie}\"");
        }
    }

    public void Stop()
    {
        _currentChapter = 0;
        Console.WriteLine($"{_description} stopped \"{_movie}\"");
    }

    public void Pause()
    {
        Console.WriteLine($"{_description} paused \"{_movie}\"");
    }

    public void SetTwoChannelAudio()
    {
        Console.WriteLine($"{_description} set two channel audio");
    }

    public void SetSurroundAudio()
    {
        Console.WriteLine($"{_description} set surround audio");
    }

    public override string ToString()
    {
        return _description;
    }
}