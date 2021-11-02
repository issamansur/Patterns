using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class GarageDoorCloseCommand : ICommand
    {
        public GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
        }

        public void Undo()
        {
            if (garageDoor.Prev == "Open")
                garageDoor.Up();
            else if (garageDoor.Prev == "Stop")
                garageDoor.Stop();
        }
    }
}