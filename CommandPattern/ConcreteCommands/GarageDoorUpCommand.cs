using CommandPattern.Commands;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands;

public class GarageDoorUpCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorUpCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute()
    {
        _garageDoor.Up();
        _garageDoor.LightOn();
    }

    public void Undo()
    {
        _garageDoor.LightOff();
        _garageDoor.Down();
    }
}