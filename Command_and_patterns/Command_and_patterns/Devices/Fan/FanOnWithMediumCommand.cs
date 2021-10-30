using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    class FanOnWithMediumCommand : ICommand
    {
        public Fan fan;

        public FanOnWithMediumCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.Medium();
        }
    }
}
