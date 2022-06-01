namespace FacadePattern;

public class Amplifier
{
    private readonly string _description = string.Empty;
    private Tuner? _tuner;
    private StreamingPlayer? _player;
    private CdPlayer? _cd;

    public Amplifier(string description)
    {
        _description = description;
    }

    public Tuner? Tuner
    {
        get
        {
            return _tuner;
        }
        set
        {
            Console.WriteLine($"{_description} setting tuner to {value}");
            _tuner = value;
        }
    }

    public StreamingPlayer? Player
    {
        get
        {
            return _player;
        }
        set
        {
            Console.WriteLine($"{_description} setting Streaming player to {value}");
            _player = value;
        }
    }

    public CdPlayer? Cd
    {
        get
        {
            return _cd;
        }
        set
        {
            Console.WriteLine($"{_description} setting Streaming player to {value}");
            _cd = value;
        }
    }

    public void On()
    {
        Console.WriteLine($"{_description} on");
    }

    public void Off()
    {
        Console.WriteLine($"{_description} off");
    }

    public void SetStereoSound()
    {
        Console.WriteLine($"{_description}  stereo mode on");
    }

    public void SetSurroundSound()
    {
        Console.WriteLine($"{_description}  surround sound on (5 speakers, 1 subwoofer)");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"{_description} setting volume to {level}");
    }

    public override string ToString()
    {
        return _description;
    }
}