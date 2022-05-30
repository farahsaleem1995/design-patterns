using CommandPattern.Commands;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands;

public class StereoOnWithCDCommand : ICommand
{
    private readonly Stereo _stereo;
    private StereoState _prevState;
    private StereoType _prevType;
    private int _prevVolume;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    public void Execute()
    {
        _prevState = _stereo.State;
        _prevType = _stereo.Type;
        _prevVolume = _stereo.Volume;
        _stereo.On();
        _stereo.SetCD();
        _stereo.SetVolume(11);
    }

    public void Undo()
    {
        if (_prevState == StereoState.Off)
        {
            _stereo.Off();
            return;
        }

        _stereo.On();
        Action setMethod = _prevType switch
        {
            StereoType.CD => _stereo.SetCD,
            StereoType.DVD => _stereo.SetDVD,
            StereoType.Radio => _stereo.SetRadio,
            _ => () => { }
        };
        setMethod();
        _stereo.SetVolume(_prevVolume);
    }
}