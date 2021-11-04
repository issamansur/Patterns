using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class StereoOnCommand : ICommand
    {
        public Stereo stereo;
        public string mode;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            mode = stereo.GetMode();
            if (mode == "Off")
                stereo.On();
            switch (mode)
            {
                case "CD":
                    stereo.SetDVD();
                    stereo.SetVolume(11);
                    break;
                case "DVD":
                    stereo.SetRadio();
                    stereo.SetVolume(15);
                    break;
                default:
                    stereo.SetCD();
                    stereo.SetVolume(20);
                    break;
            }
        }

        public void Undo()
        {
            mode = stereo.GetMode();
            switch (mode)
            {
                case "Radio":
                    stereo.SetDVD();
                    stereo.SetVolume(15);
                    break;
                case "DVD":
                    stereo.SetCD();
                    stereo.SetVolume(11);
                    break;
                default:
                    stereo.Off();
                    break;
            }
        }
    }
}
