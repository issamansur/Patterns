﻿using System;

namespace Command_and_patterns
{
    class Program
    {
        static void Main()
        {
            RemoteControl remote = new RemoteControl();
            
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            Fan fan = new Fan("Living room");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn =
                new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff =
                new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn =
                new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff =
                new LightOffCommand(kitchenLight);

            FanOnWithLowCommand fanOn = 
                new FanOnWithLowCommand(fan);
            FanOffCommand fanOff =
                new FanOffCommand(fan);

            GarageDoorOpenCommand garageDoorOpen =
                new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorClose =
                new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD =
                new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff =
                new StereoOffCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, fanOn, fanOff);
            remote.SetCommand(3, garageDoorOpen, garageDoorClose);
            remote.SetCommand(4, stereoOnWithCD, stereoOff);

            Console.WriteLine(remote);

            for (int i = 0; i < 7; i++)
            {
                remote.OnButtonWasPressed(i);
                remote.OffButtonWasPressed(i);
                Console.WriteLine();
            }
        }
    }
}