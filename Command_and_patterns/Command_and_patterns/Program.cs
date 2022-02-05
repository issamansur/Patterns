using System;

namespace Command_and_patterns
{
    class Program
    {
        static void Main()
        {
            

            Fan fan = new Fan("Living room");
            FanOnCommand fanOn = new FanOnCommand(fan);
            FanOffCommand fanOff = new FanOffCommand(fan);
            OnOffCommand fanCommand = new OnOffCommand(fanOn, fanOff);

            Fan fan2 = new Fan("Living room");
            FanOnCommand fanOn2 = new FanOnCommand(fan2);
            FanOffCommand fanOff2 = new FanOffCommand(fan2);
            OnOffCommand fanCommand2 = new OnOffCommand(fanOn2, fanOff2);

            OnOffCommand[] commands = new OnOffCommand[7];
            commands[0] = fanCommand;
            commands[1] = fanCommand2;

            RemoteControl remote = new RemoteControl(commands);


            remote.OnButtonWasPressed(0);
            remote.OnButtonWasPressed(0);
            remote.UndoButtonWasPressed();
        }
    }
}
