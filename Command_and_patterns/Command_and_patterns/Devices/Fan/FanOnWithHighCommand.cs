using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    class FanOnWithHighCommand : ICommand
    {
        public Fan fan;

        public FanOnWithHighCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.High();
        }
    }
}