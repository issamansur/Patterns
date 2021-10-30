using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class FanOffCommand : ICommand
    {
        public Fan fan;

        public FanOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.Off();
        }
    }
}
