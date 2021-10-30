using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    class FanGetSpeedCommand : ICommand
    {
        public Fan fan;

        public FanGetSpeedCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.GetSpeed();
        }
    }
}
