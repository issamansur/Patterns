using System;

namespace Facade_and_patterns
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Свет включен");
        }

        public void Dim(int brightness)
        {
            Console.WriteLine($"Яркость света: {brightness}%");
        }

        public void Off()
        {
            Console.WriteLine("Свет выключен");
        }
    }
}