using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class StereoOffCommand : ICommand
    {
        public Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }
    }
}
