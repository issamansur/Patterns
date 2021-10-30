﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class GarageDoorStopCommand : ICommand
    {
        public GarageDoor garageDoor;

        public GarageDoorStopCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Stop();
        }
    }
}