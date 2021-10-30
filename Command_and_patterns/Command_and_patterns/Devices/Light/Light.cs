using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class Light
    {
        public string Room;

        public Light(string room)
        {
            this.Room = room;
        }

        public void On()
        {
            Console.WriteLine($"{Room} light ON!");
        }

        public void Off()
        {
            Console.WriteLine($"{Room} light OFF!");
        }
    }
}
