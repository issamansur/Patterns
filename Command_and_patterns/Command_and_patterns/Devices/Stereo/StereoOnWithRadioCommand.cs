using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class StereoOnWithRadioCommand : ICommand
    {
        public Stereo stereo;

        public StereoOnWithRadioCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetRadio();
            stereo.SetVolume(11);
        }
    }
}