using System.Text;
using CommandPattern.Commands;
using CommandPattern.ConcreteCommands;

namespace CommandPattern.Invokers;

public class RemoteControl
{
    private const int CommandLenght = 7;
    private readonly ICommand[] _onCommands = new ICommand[CommandLenght];
    private readonly ICommand[] _offCommands = new ICommand[CommandLenght];
    private Stack<ICommand> _undoCommand = new Stack<ICommand>();

    public RemoteControl()
    {
        for (var i = 0; i < CommandLenght; i++)
        {
            _onCommands[i] = new NoCommand();
            _offCommands[i] = new NoCommand();
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButton(int slot)
    {
        _undoCommand.Push(_onCommands[slot]);
        _onCommands[slot].Execute();
    }

    public void OffButton(int slot)
    {
        _undoCommand.Push(_offCommands[slot]);
        _offCommands[slot].Execute();
    }

    public void UndoButton()
    {
        _undoCommand.Pop().Undo();
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("\n------ Remote Control -------\n");
        for (int i = 0; i < CommandLenght; i++)
        {
            builder.Append($"[slot {i}] {_onCommands[i].GetType().Name}    {_offCommands[i].GetType().Name} \n");
        }
        builder.Append($"[undo] {_undoCommand.GetType().Name} \n");
        return builder.ToString();
    }
}