namespace FacadePattern.Facades;

public class HomeTheaterFacade
{
    private readonly Amplifier _amplifier;
    private readonly Tuner _tuner;
    private readonly StreamingPlayer _player;
    private readonly CdPlayer _cd;
    private readonly Projector _projector;
    private readonly Screen _screen;
    private readonly TheaterLights _lights;
    private readonly PopcornPopper _popper;

    public HomeTheaterFacade(
        Amplifier amplifier,
        Tuner tuner,
        StreamingPlayer player,
        CdPlayer cd,
        Projector projector,
        Screen screen,
        TheaterLights lights,
        PopcornPopper popper)
    {
        _amplifier = amplifier;
        _tuner = tuner;
        _player = player;
        _cd = cd;
        _projector = projector;
        _screen = screen;
        _lights = lights;
        _popper = popper;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _popper.On();
        _popper.Pop();
        _lights.Dim(10);
        _screen.Down();
        _projector.On();
        _projector.WideScreenMode();
        _amplifier.On();
        _amplifier.Player = _player;
        _amplifier.SetStereoSound();
        _amplifier.SetVolume(5);
        _player.On();
        _player.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");
        _popper.Off();
        _lights.On();
        _screen.Up();
        _projector.Off();
        _amplifier.Off();
        _player.Stop();
        _player.Off();
    }

    public void ListenToRadio(double frequency)
    {
        Console.WriteLine("Tuning in the airwaves...");
        _tuner.On();
        _tuner.SetFrequency(frequency);
        _amplifier.On();
        _amplifier.SetVolume(5);
        _amplifier.Tuner = _tuner;
    }

    public void EndRadio()
    {
        Console.WriteLine("Shutting down the tuner...");
        _tuner.Off();
        _amplifier.Off();
    }
}