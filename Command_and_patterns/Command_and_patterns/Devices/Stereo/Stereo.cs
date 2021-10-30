using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class Stereo
    {
        public string Room;

        public Stereo(string room)
        {
            this.Room = room;
        }

        public void On()
        {
            Console.WriteLine($"{Room} stereo ON!");
        }

        public void Off()
        {
            Console.WriteLine($"{Room} stereo OFF!");
        }

        public void SetCD()
        {
            Console.WriteLine($"{Room} stereo: CD has been set!");
        }

        public void SetDVD()
        {
            Console.WriteLine($"{Room} stereo: DVD has been set!");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{Room} stereo: Radio has been set");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"{Room} stereo volume: {value}");
        }
    }
}
