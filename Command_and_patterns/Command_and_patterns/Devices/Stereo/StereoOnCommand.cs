using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class StereoOnCommand : ICommand
    {
        public Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
        }
    }
}
