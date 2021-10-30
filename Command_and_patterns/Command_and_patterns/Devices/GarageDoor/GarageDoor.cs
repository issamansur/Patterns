using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door opening...");
        }

        public void Down()
        {
            Console.WriteLine("Garage door closing...");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door was stoped!");
        }

        public void LightOn()
        {
            Console.WriteLine("Light ON!");
        }

        public void LightOff()
        {
            Console.WriteLine("Light OFF!");
        }
    }
}
