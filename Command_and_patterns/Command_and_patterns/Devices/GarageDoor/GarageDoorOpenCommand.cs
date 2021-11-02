using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class GarageDoorOpenCommand : ICommand
    {
        public GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Up();
        }

        public void Undo()
        {
            if (garageDoor.Prev == "Close")
                garageDoor.Down();
            else if (garageDoor.Prev == "Stop")
                garageDoor.Stop();
        }
    }
}
