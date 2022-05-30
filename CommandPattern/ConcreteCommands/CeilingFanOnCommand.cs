using CommandPattern.Commands;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands;

public class CeilingFanOnCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;
    private int _prevSpeed;

    public CeilingFanOnCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        _prevSpeed = _ceilingFan.Speed;
        _ceilingFan.OnHigh();
    }

    public void Undo()
    {
        switch (_prevSpeed)
        {
            case CeilingFan.High:
                _ceilingFan.OnHigh();
                break;

            case CeilingFan.Medium:
                _ceilingFan.OnMedium();
                break;

            case CeilingFan.Low:
                _ceilingFan.OnLow();
                break;

            default:
                _ceilingFan.Off();
                break;
        }
    }
}