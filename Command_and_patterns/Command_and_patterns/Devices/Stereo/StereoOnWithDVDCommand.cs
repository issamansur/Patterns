using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class StereoOnWithDVDCommand : ICommand
    {
        public Stereo stereo;

        public StereoOnWithDVDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetDVD();
            stereo.SetVolume(11);
        }
    }
}