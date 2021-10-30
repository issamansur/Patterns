using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class StereoSetVolumeCommand : ICommand
    {
        public Stereo stereo;
        public int value;

        public StereoSetVolumeCommand(Stereo stereo, int value)
        {
            this.stereo = stereo;
            this.value = value;
        }

        public void Execute()
        {
            stereo.SetVolume(value);
        }
    }
}