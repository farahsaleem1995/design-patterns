using CommandPattern.Commands;

namespace CommandPattern.ConcreteCommands;

public class NoCommand : ICommand
{
    public void Execute()
    {
        Console.Write("");
    }

    public void Undo()
    {
        Console.Write("");
    }
}