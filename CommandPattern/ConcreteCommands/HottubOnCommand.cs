using CommandPattern.Commands;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands;

public class HottubOnCommand : ICommand
{
    private readonly Hottub _hottub;

    public HottubOnCommand(Hottub hottub)
    {
        _hottub = hottub;
    }

    public void Execute()
    {
        _hottub.Heat();
        _hottub.On();
        _hottub.BubblesOn();
    }

    public void Undo()
    {
        _hottub.Cool();
        _hottub.Off();
        _hottub.BubblesOff();
    }
}