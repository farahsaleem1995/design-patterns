using CommandPattern.Commands;

namespace CommandPattern.ConcreteCommands;

public class MacroCommand : ICommand
{
    private readonly IEnumerable<ICommand> _command = new List<ICommand>();

    public MacroCommand(params ICommand[] commands)
    {
        _command = commands;
    }

    public void Execute()
    {
        foreach (var command in _command)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        foreach (var command in _command)
        {
            command.Undo();
        }
    }
}