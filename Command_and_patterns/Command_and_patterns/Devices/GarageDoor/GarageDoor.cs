﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class GarageDoor
    {
        public string Prev;

        public GarageDoor()
        {
            this.Prev = "Stop";
        }

        public void Up()
        {
            Console.WriteLine("Garage door opening...");
            this.Prev = "Open";
        }

        public void Down()
        {
            Console.WriteLine("Garage door closing...");
            this.Prev = "Close";
        }

        public void Stop()
        {
            Console.WriteLine("Garage door was stoped!");
            this.Prev = "Stop";
        }
    }
}
