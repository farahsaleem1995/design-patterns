using CommandPattern.Commands;
using CommandPattern.ConcreteCommands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace App.Clients;

public class CommandClient
{
    public static void Execute()
    {
        var remoteControl = new RemoteControl();

        #region Receivers

        var livingRoomLight = new Light("Living Room");
        var kitchenLight = new Light("Kitchen");
        var ceilingFan = new CeilingFan("Living Room");
        var garageDoor = new GarageDoor("Garage");
        var stereo = new Stereo("Living Room");

        #endregion Receivers

        #region Commands

        ICommand livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
        ICommand livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);

        ICommand kitchenLightOnCommand = new LightOnCommand(kitchenLight);
        ICommand kitchenLightOffCommand = new LightOffCommand(kitchenLight);

        ICommand ceilingFanOnCommand = new CeilingFanOnCommand(ceilingFan);
        ICommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

        ICommand garageDoorUpCommand = new GarageDoorUpCommand(garageDoor);
        ICommand garageDoorDownCommand = new GarageDoorDownCommand(garageDoor);

        ICommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
        ICommand stereoOffCommand = new StereoOffCommand(stereo);

        ICommand partyModeOnCommand = new MacroCommand(livingRoomLightOnCommand,
                                                       ceilingFanOnCommand,
                                                       stereoOnWithCDCommand);
        ICommand partyModeOffCommand = new MacroCommand(livingRoomLightOffCommand,
                                                        ceilingFanOffCommand,
                                                        stereoOffCommand);

        #endregion Commands

        #region Set Commands

        remoteControl.SetCommand(0, livingRoomLightOnCommand, livingRoomLightOffCommand);
        remoteControl.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);
        remoteControl.SetCommand(2, ceilingFanOnCommand, ceilingFanOffCommand);
        remoteControl.SetCommand(3, garageDoorUpCommand, garageDoorDownCommand);
        remoteControl.SetCommand(4, stereoOnWithCDCommand, stereoOffCommand);
        remoteControl.SetCommand(5, partyModeOnCommand, partyModeOffCommand);

        #endregion Set Commands

        Console.WriteLine(remoteControl);

        #region Slot 0

        Console.WriteLine("Slot 0:");
        Console.WriteLine("On:");
        remoteControl.OnButton(0);
        Console.WriteLine("Off:");
        remoteControl.OffButton(0);
        Console.WriteLine("On:");
        remoteControl.OnButton(0);
        Console.WriteLine("Off:");
        remoteControl.OffButton(0);
        Console.WriteLine("On:");
        remoteControl.OnButton(0);
        Console.WriteLine("Off:");
        remoteControl.OffButton(0);
        Console.WriteLine();

        #endregion Slot 0

        #region Slot 1

        Console.WriteLine("Slot 1:");
        Console.WriteLine("On:");
        remoteControl.OnButton(1);
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();

        #endregion Slot 1

        #region Slot 2

        Console.WriteLine("Slot 2:");
        Console.WriteLine("On:");
        remoteControl.OnButton(2);
        Console.WriteLine("Off:");
        remoteControl.OffButton(2);
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();

        #endregion Slot 2

        #region Slot 3

        Console.WriteLine("Slot 3:");
        Console.WriteLine("On:");
        remoteControl.OnButton(3);
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine("On:");
        remoteControl.OnButton(3);
        Console.WriteLine("Off:");
        remoteControl.OffButton(3);
        Console.WriteLine();

        #endregion Slot 3

        #region Slot 4

        Console.WriteLine("Slot 4:");
        Console.WriteLine("On:");
        remoteControl.OnButton(4);
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();

        Console.WriteLine("On:");
        remoteControl.OnButton(4);
        Console.WriteLine("Off:");
        remoteControl.OffButton(4);
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();

        #endregion Slot 4

        #region Party Mode Slot

        Console.WriteLine("Slot 5");
        Console.WriteLine("On:");
        remoteControl.OnButton(5);
        Console.WriteLine("Off:");
        remoteControl.OffButton(5);

        Console.WriteLine("On:");
        remoteControl.OnButton(5);
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();

        #endregion Party Mode Slot

        #region Undoing

        Console.WriteLine("Undoing");
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();
        Console.WriteLine();
        Console.WriteLine("Undo:");
        remoteControl.UndoButton();

        #endregion Undoing
    }
}