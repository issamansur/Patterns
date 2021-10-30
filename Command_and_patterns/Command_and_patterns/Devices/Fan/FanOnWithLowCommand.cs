using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    class FanOnWithLowCommand : ICommand
    {
        public Fan fan;

        public FanOnWithLowCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.Low();
        }
    }
}