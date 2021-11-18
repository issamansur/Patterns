using System;

namespace Facade_and_patterns
{
    public class Projector
    {
        private DVDPlayer player;

        public Projector(DVDPlayer player)
        {
            this.player = player;
        }

        public void On()
        {
            Console.WriteLine("Проектор включён");
        }

        public void TVMode()
        {
            Console.WriteLine("Режим проектора: Телевизор");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Режим проектора: Широкоэкранный");
        }

        public void Off()
        {
            Console.WriteLine("Проектор выключен");
        }
    }
}
