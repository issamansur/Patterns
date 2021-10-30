using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class Fan
    {
        public string Room;
        public string Speed;

        public Fan(string room)
        {
            this.Room = room;
            this.Speed = "0";
        }

        public void High()
        {
            Console.WriteLine($"{Room} fan Speed: High!");
            Speed = "High";
        }

        public void Medium()
        {
            Console.WriteLine($"{Room} fan Speed: Medium!");
            Speed = "Medium";
        }

        public void Low()
        {
            Console.WriteLine($"{Room} fan Speed: Low!");
            Speed = "Low";
        }

        public void Off()
        {
            Console.WriteLine($"{Room} fan OFF!");
            Speed = "0";
        }

        public void GetSpeed()
        {
            Console.WriteLine($"{Room} fan speed: {this.Speed}");
        }
    }
}
