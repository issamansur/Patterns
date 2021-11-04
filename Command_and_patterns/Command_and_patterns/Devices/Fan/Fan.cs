using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class Fan
    {
        public string Room;
        public int Speed;

        public Fan(string room)
        {
            this.Room = room;
            this.Speed = 0;
        }

        public void High()
        {
            Console.WriteLine($"{Room} fan Speed: High!");
            Speed = 3;
        }

        public void Medium()
        {
            Console.WriteLine($"{Room} fan Speed: Medium!");
            Speed = 2;
        }

        public void Low()
        {
            Console.WriteLine($"{Room} fan Speed: Low!");
            Speed = 1;
        }

        public void Off()
        {
            Console.WriteLine($"{Room} fan OFF!");
            Speed = 0;
        }

        public int GetSpeed()
        {
            return Speed;
        }
    }
}
