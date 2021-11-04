using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class Stereo
    {
        public string Room;
        protected string Mode;

        public Stereo(string room)
        {
            this.Room = room;
            Mode = "Off";
        }

        public void On()
        {
            Console.WriteLine($"{Room} stereo ON!");
        }

        public void Off()
        {
            Console.WriteLine($"{Room} stereo OFF!");
            Mode = "Off";
        }

        public void SetCD()
        {
            Console.WriteLine($"{Room} stereo: CD has been set!");
            Mode = "CD";
        }

        public void SetDVD()
        {
            Console.WriteLine($"{Room} stereo: DVD has been set!");
            Mode = "DVD";
        }

        public void SetRadio()
        {
            Console.WriteLine($"{Room} stereo: Radio has been set");
            Mode = "Radio";
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"{Room} stereo: Volume set {value}");
        }

        public string GetMode()
        {
            return Mode;
        }
    }
}
