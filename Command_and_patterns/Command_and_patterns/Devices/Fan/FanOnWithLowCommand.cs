using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    class FanOnWithLowCommand : ICommand
    {
        public Fan fan;
        public int prev;

        public FanOnWithLowCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            prev = fan.GetSpeed();
            switch (prev)
            {
                case 1:
                    fan.Medium();
                    break;
                case 2:
                    fan.High();
                    break;
                default:
                    fan.Low();
                    break;
            }
        }

        public void Undo()
        {
            prev = fan.GetSpeed();
            switch (prev)
            {
                case 1:
                    fan.Off();
                    break;
                case 2:
                    fan.Low();
                    break;
                case 3:
                    fan.Medium();
                    break;
            }
        }
    }
}