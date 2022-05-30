using CommandPattern.Commands;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands;

public class HottubOffCommand : ICommand
{
    private readonly Hottub _hottub;

    public HottubOffCommand(Hottub hottub)
    {
        _hottub = hottub;
    }

    public void Execute()
    {
        _hottub.Cool();
        _hottub.Off();
        _hottub.BubblesOff();
    }

    public void Undo()
    {
        _hottub.Heat();
        _hottub.On();
        _hottub.BubblesOn();
    }
}